﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

/*
Copyright 2015 NIC Federal

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/
namespace NICFederal.RIDB.Client
{
    /// <summary>
    /// Contains information on a external resources related to a RIDB entity
    /// </summary>
    [DataContract(Name="EntityLink")]
    public class RIDBEntityLink
    {
        // RIDB BUG:  The EntityLinkID field is missing from the data dictionary
        /// <summary>
        /// The id of the entity link.
        /// </summary>
        [DataMember]
        public int EntityLinkID { get; set; }
        
        /// <summary>
        /// The type of entity with which the link is related (e.g. Rec Area or Facility).
        /// </summary>
        [DataMember]
        public string EntityType { get; set; }
        
        /// <summary>
        /// The id of the entity with which the link is related.
        /// </summary>
        [DataMember]
        public int EntityID { get; set; }
        
        /// <summary>
        /// Type of link, e.g. Facebook, Twitter, Official site
        /// </summary>
        [DataMember]
        public string LinkType { get; set; }
        
        /// <summary>
        /// The URL for the link.
        /// </summary>
        [DataMember]
        public string URL { get; set; }
        
        /// <summary>
        /// The title of the link.
        /// </summary>
        [DataMember]
        public string Title { get; set; }
        
        /// <summary>
        /// The description of the link.
        /// </summary>
        [DataMember]
        public string Description { get; set; }
    }
}
