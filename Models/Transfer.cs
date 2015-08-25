﻿using FluentValidation;
using Scaffold.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Http.Validation;

namespace App.Models
{
    public class BaseTransfer : BaseEntity, IDocumentUploadEntry
    {
        public decimal? Dd { get; set; }
        public decimal? Add { get; set; }
        public decimal? Bhpr { get; set; }

        public DateTime Date { get; set; }

        [Index]
        public bool IsActivated { get; set; }

        public int Year { get; set; }

        [ForeignKey("Region")]
        public string fkRegionId { get; set; }
        public virtual Region Region { get; set; }
        
        [ForeignKey("DocumentUpload")]
        public long fkDocumentUploadId { get; set; }
        public virtual DocumentUpload DocumentUpload { get; set; }


        [Validator]
        public IEnumerable<ModelValidationResult> Validate()
        {
            return new List<ModelValidationResult>();
        }
    }

    public class Transfer : BaseTransfer
    {
    }

    public class FrozenTransfer : BaseTransfer
    {
    }
}