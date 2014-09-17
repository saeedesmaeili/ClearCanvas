#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.clearcanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

// This file is auto-generated by the ClearCanvas.Model.SqlServer.CodeGenerator project.

namespace ClearCanvas.ImageServer.Model.EntityBrokers
{
    using System;
    using System.Xml;
    using ClearCanvas.Enterprise.Core;
    using ClearCanvas.ImageServer.Enterprise;

    public partial class StaffSelectCriteria : EntitySelectCriteria
    {
        public StaffSelectCriteria()
        : base("Staff")
        {}
        public StaffSelectCriteria(StaffSelectCriteria other)
        : base(other)
        {}
        public override object Clone()
        {
            return new StaffSelectCriteria(this);
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Staff", ColumnName="ServerPartitionGUID")]
        public ISearchCondition<ServerEntityKey> ServerPartitionKey
        {
            get
            {
              if (!SubCriteria.ContainsKey("ServerPartitionKey"))
              {
                 SubCriteria["ServerPartitionKey"] = new SearchCondition<ServerEntityKey>("ServerPartitionKey");
              }
              return (ISearchCondition<ServerEntityKey>)SubCriteria["ServerPartitionKey"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Staff", ColumnName="Identifier")]
        public ISearchCondition<String> Identifier
        {
            get
            {
              if (!SubCriteria.ContainsKey("Identifier"))
              {
                 SubCriteria["Identifier"] = new SearchCondition<String>("Identifier");
              }
              return (ISearchCondition<String>)SubCriteria["Identifier"];
            } 
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Staff", ColumnName="Name")]
        public ISearchCondition<String> Name
        {
            get
            {
              if (!SubCriteria.ContainsKey("Name"))
              {
                 SubCriteria["Name"] = new SearchCondition<String>("Name");
              }
              return (ISearchCondition<String>)SubCriteria["Name"];
            } 
        }
    }
}
