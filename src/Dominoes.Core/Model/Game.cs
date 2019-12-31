using System;
using System.Collections.Generic;

namespace Dominoes.Core.Model
{
    public class Game
    {
        public Guid GameId { get; set; }
        public ICollection<Player> Players { get; set; }
    }
}
