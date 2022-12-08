using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Karen Tituaña 
namespace Tetris
{
    // Clase hija (TBlock) de una clase padre (Block)
    public class TBlock : Block
    {
        public override int Id => 6;

        protected override Position StartOffset => new(0, 3);

        protected override Position[][] Tiles => new Position[][] {
    // El bloque T tiene 4 movimientos
            new Position[] {new(0,1), new(1,0), new(1,1), new(1,2)},
            new Position[] {new(0,1), new(1,1), new(1,2), new(2,1)},    
            new Position[] {new(1,0), new(1,1), new(1,2), new(2,1)},
            new Position[] {new(0,1), new(1,0), new(1,1), new(2,1)}
        };
    
    }
}
