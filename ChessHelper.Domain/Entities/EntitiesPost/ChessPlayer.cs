﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Domain.Entities.EntitiesPost
{
    public class ChessPlayer
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("full_name")]
        public string FIO { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("picture")]
        public string PathPicture { get; set; }
        [Column("rank")]
        public string Rank { get; set; }
    }
}