﻿using Core.Entities;

namespace Entities.DTOs
{
    public class MessageUpdateDto : IDTOs
    {
        public int Id { get; set; } 
        public string Content { get; set; } 
    }
}
