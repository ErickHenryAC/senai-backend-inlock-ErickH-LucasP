﻿using Senai.InLock.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.Interfaces
{
    interface IJogosRepository
    {
        List<JogosDomain> ListarJogos();

        void CadastrarJogos(JogosDomain novoJogo);

        void DeletarJogo(int id);

        JogosDomain BuscarJogoPorId(int id);
    }
}
