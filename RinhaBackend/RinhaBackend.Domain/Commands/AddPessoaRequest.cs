﻿using RinhaBackend.Domain.Validators;

namespace RinhaBackend.Domain.Commands
{
    public class AddPessoaRequest
    {
        public string Apelido { get; set; }
        public string Nome { get; set; }
        public string Nascimento { get; set; }
        public IEnumerable<string> Stack { get; set; }

    }
}
