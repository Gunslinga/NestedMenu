using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NestedMenu.Models
{
    public class RootElement
    {
        public List<ChildElement> ChildElements { get; set; }
    }
    public class ChildElement
    {
        public List<RootElement> RootElements { get; set; }
    }
    public static class GenereteNestedMenu
    {
        public static List<RootElement> GenerateMenu()
        {
            var elements = new List<RootElement>();

            var root = new RootElement();

            for (int i = 0; i < 5; i++)
            {
                var childElement = new ChildElement();
                childElement.RootElements.Add(new RootElement());
                childElement.RootElements.Add(new RootElement());
                childElement.RootElements.Add(new RootElement());

                root.ChildElements.Add(childElement);
            }

            root.ChildElements[2].RootElements[1].ChildElements.Add(new ChildElement());
            elements.Add(new RootElement());

            return elements;
        }
    }
}
