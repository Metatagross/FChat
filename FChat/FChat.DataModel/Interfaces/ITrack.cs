﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FChat.DataModel.Interfaces
{
    public interface ITrack
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        int Id { get; set; }

        [Required]
        DateTime CreatedOn { get; set; }

        DateTime DeletedOn { get; set; }

        DateTime ModifiedOn { get; set; }
    }
}
