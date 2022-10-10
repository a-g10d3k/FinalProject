﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Collection
    {
        public const int MaxNameLength = 50;
        public const int MaxDescriptionLength = 1000;
        public const string AllowedTopics = "Books|Stamps|Coins";
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxNameLength)]
        public string Name { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Created { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Modified { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [MaxLength(MaxDescriptionLength)]
        public string Description { get; set; }

        [Required]
        [RegularExpression(AllowedTopics)] 
        public string Topic { get; set; }

        [ForeignKey("CollectionImage")]
        public int? ImageId { get; set; }
        public CollectionImage? Image { get; set; }

        public List<CollectionItem> Items { get; set; } = new List<CollectionItem>();

        public string? AuthorId { get; set; }
        public ApplicationUser? Author { get; set; }

        public List<CustomIntField> CustomIntFields { get; set; } = new List<CustomIntField>();
        public List<CustomStringField> CustomStringFields { get; set; } = new List<CustomStringField>();
        public List<CustomTextAreaField> CustomTextAreaFields { get; set; } = new List<CustomTextAreaField>();
        public List<CustomBoolField> CustomBoolFields { get; set; } = new List<CustomBoolField>();
        public List<CustomDateField> CustomDateFields { get; set; } = new List<CustomDateField>();
    }
}
