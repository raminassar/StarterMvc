using System.Collections.Generic;
using System.Text;

namespace StarterMvc.Web.Core.Models
{
    public class DataTableResult
    {
        private List<string> _Header;

        private string _JsonHeader;

        public string TableId { get; set; }
        public List<string> Header
        {
            get { return _Header; }

            set
            {
                _Header = value;

                StringBuilder headerProperty = new StringBuilder();
                headerProperty.Append("[");
                foreach (var item in Header)
                {
                    headerProperty.Append("{ 'mData': '" + item + "', sDefaultContent: '' },");
                }
                headerProperty.Append("]");

                _JsonHeader = headerProperty.ToString().Replace(",]", "]");
            }
        }

        public string JsonData { get; set; }

        public string JsonHeader { get { return _JsonHeader; } }
    }
}