﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace AspNetMvcTutorial.Models
{
    public class Test
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        Int32 ID;

        [Required]
        String Name { set; get; }

        [Required]
        Int16 TestGroupNo { set; get; }

        [Required]
        TestType TestType { set; get; }

        [Required]
        List<Quiz> TestQuizzes { set; get; }
        
        Int16 Score { set; get; }
        
        Decimal ScorePercent { set; get; }

        public Test(String tName, Int16 tGrNo, TestType tType)
        {
            this.Name = tName;
            this.TestGroupNo = tGrNo;
            this.TestType = tType;
        }

    }
}