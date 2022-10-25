﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Models
{
    public class Cinema
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' não pode ser vazio")]
        public string Nome { get; set; }
        public Filme FilmesDisponiveis { get; set; }
    }
}
