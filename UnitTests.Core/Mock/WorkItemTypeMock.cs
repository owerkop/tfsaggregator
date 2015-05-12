﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Core.Mock
{
    using System.Xml;
    using Aggregator.Core;

    internal class WorkItemTypeMock : IWorkItemType
    {
        public string Name { get; set; }
        public string DocumentContent { get; set; }

        public XmlDocument Export(bool includeGlobalListsFlag)
        {
            var doc = new XmlDocument();
            doc.LoadXml(this.DocumentContent);
            return doc;
        }
    }
}
