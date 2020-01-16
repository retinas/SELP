﻿using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class ContentCategory : AuditableEntity
    {
        public ContentCategory()
        {
            Contents = new HashSet<Content>();
        }
        public int Id { get; set; }
        public string Description { get; set; }
        public int Code { get; set; }
        public ICollection<Content> Contents { get; private set; }
    }
}
