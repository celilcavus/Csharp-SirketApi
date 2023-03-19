using Microsoft.AspNetCore.Mvc.Routing;

namespace SirketApis.Atribute
{
    public class MyApiRoute : Attribute,IRouteTemplateProvider
    {
        private int? _order;
        public MyApiRoute()
        {
            Template = "api/[controller]/[action]" ?? throw new ArgumentNullException(nameof(Template));
        }

        public string? Template { get; }

        public int Order
        {
            get { return _order ?? 0; }
            set { _order = value; }
        }

        /// <inheritdoc />
        int? IRouteTemplateProvider.Order => _order;

        /// <inheritdoc />
        public string? Name { get; set; }
    }
}
