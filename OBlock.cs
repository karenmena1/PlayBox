namespace Tetris
//Karen Tituaña
{
    // Clase hija (OBlock) de una clase padre (Block)
    public class OBlock : Block
    {
        public override int Id => 4;
        protected override Position StartOffset => new Position(0, 4);
        protected override Position[][] Tiles => tiles;

        private readonly Position[][] tiles = new Position[][]
        {
            // El bloque O no tiene movimientos
            new Position[] { new(0,0), new(0,1), new(1,0), new(1,1) }
        };
    }
     
}
