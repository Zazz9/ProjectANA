﻿using System.Collections.Generic;

namespace ANAConversationPlatform.Models
{
    public class ChatFlowPack : BaseIdTimestampEntity
    {
        public string ProjectId { get; set; }

        public List<ChatNode> ChatNodes { get; set; }
        public List<BaseContent> ChatContent { get; set; }
        public Dictionary<string, LayoutPoint> NodeLocations { get; set; }
    }
}