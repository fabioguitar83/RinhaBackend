﻿namespace RinhaBackend.Domain.Entities
{
    public class PessoaEntity
    {
        public Guid Id { get; set; }
        public string Apelido { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Stack { get; set; }
    }
}
