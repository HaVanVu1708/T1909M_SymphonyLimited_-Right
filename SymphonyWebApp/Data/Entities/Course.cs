﻿using SymphonyWebApp.Data.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SymphonyWebApp.Data.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public int CourseId { get; set; }

        public string CourseName { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Fee { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal SubFee { get; set; }

        public Level level { get; set; }
        public FeeStatus FeeStatus { get; set; }

        [DataType(DataType.Date)]
        public DateTime TrainingTime { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartTime { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndTime { get; set; }
    }
}