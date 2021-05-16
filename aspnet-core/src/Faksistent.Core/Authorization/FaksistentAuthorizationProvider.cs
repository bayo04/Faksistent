using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;
using System;
using System.Collections.Generic;

namespace Faksistent.Authorization
{
    public class FaksistentAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Users_Activation, L("UsersActivation"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);

            RegisterPermissions(context);
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, FaksistentConsts.LocalizationSourceName);
        }

        private void RegisterPermissions(IPermissionDefinitionContext context)
        {
            Type type = typeof(PermissionNames);

            var specialPermissions = new List<string> {
                PermissionNames.Pages_Users,
                PermissionNames.Pages_Users_Activation,
                PermissionNames.Pages_Roles,
                PermissionNames.Pages_Tenants
            };

            foreach (var p in type.GetFields())
            {
                var value = p.GetValue(null).ToString(); // static classes cannot be instanced, so use null...

                //register permissions normally
                if (!specialPermissions.Contains(value))
                {
                    //checking for child permission
                    if (value.Contains("."))
                    {
                        var parentPermission = context.GetPermissionOrNull(value.Split('.')[0]);

                        //if parent permission exists, create permission as child of it and save feature dependency from parent
                        if (parentPermission != null)
                            parentPermission.CreateChildPermission(value.ToString(), L(value.ToString()), featureDependency: parentPermission.FeatureDependency, multiTenancySides: MultiTenancySides.Tenant);
                        //else create it normally
                        else
                            context.CreatePermission(value.ToString(), L(value.ToString()), multiTenancySides: MultiTenancySides.Tenant);
                    }
                    else
                    {
                        context.CreatePermission(value.ToString(), L(value.ToString()), multiTenancySides: MultiTenancySides.Tenant);
                    }
                }
            }
        }
    }
}
