using System;
using System.Collections.Generic;

namespace SysDoc.Models
{
    public class Node
    {
        public virtual int? Id { get; protected set; }
        public virtual string Name { get; set; }
    }
}
