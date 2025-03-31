using RubiksCube.Enums;
using RubiksCube.Models;

namespace RubiksCube.Utilities
{
    public static class RotationUtilities
    {
        public static IndexMove[][] GetSideMoves(Move direction)
        {
            return direction switch
            {
                Move.F or Move.FPrime => FrontSideMoves(),
                Move.R or Move.RPrime => RightSideMoves(),
                Move.U or Move.UPrime => TopSideMoves(),
                Move.B or Move.BPrime => BackSideMoves(),
                Move.L or Move.LPrime => LeftSideMoves(),
                Move.D or Move.DPrime => DownSideMoves(),
                _ => throw new NotImplementedException()
            };
        }

        private static IndexMove[][] FrontSideMoves()
        {
            IndexMove[] faceMoves = FaceMoves(Face.Front);

            IndexMove[] topMoves =
                [ new IndexMove(from: new Tile(Face.Top, [2,0]), to: new Tile(Face.Right, [0,0])),
                  new IndexMove(from: new Tile(Face.Top, [2,1]), to: new Tile(Face.Right, [1,0])),
                  new IndexMove(from: new Tile(Face.Top, [2,2]), to: new Tile(Face.Right, [2,0]))
                ];

            IndexMove[] rightMoves =
                [ new IndexMove(from: new Tile(Face.Right, [0,0]), to: new Tile(Face.Down, [0,2])),
                  new IndexMove(from: new Tile(Face.Right, [1,0]), to: new Tile(Face.Down, [0,1])),
                  new IndexMove(from: new Tile(Face.Right, [2,0]), to: new Tile(Face.Down, [0,0]))
                ];

            IndexMove[] downMoves =
                [ new IndexMove(from: new Tile(Face.Down, [0,0]), to: new Tile(Face.Left, [0,2])),
                  new IndexMove(from: new Tile(Face.Down, [0,1]), to: new Tile(Face.Left, [1,2])),
                  new IndexMove(from: new Tile(Face.Down, [0,2]), to: new Tile(Face.Left, [2,2]))
                ];

            IndexMove[] leftMoves =
                [ new IndexMove(from: new Tile(Face.Left, [0,2]), to: new Tile(Face.Top, [2,2])),
                  new IndexMove(from: new Tile(Face.Left, [1,2]), to: new Tile(Face.Top, [2,1])),
                  new IndexMove(from: new Tile(Face.Left, [2,2]), to: new Tile(Face.Top, [2,0]))
                ];
            return [faceMoves, topMoves, rightMoves, downMoves, leftMoves];
        }

        private static IndexMove[][] RightSideMoves()
        {
            IndexMove[] faceMoves = FaceMoves(Face.Right);

            IndexMove[] topMoves =
                [ new IndexMove(from: new Tile(Face.Top, [2,2]), to: new Tile(Face.Back, [0,0])),
                  new IndexMove(from: new Tile(Face.Top, [1,2]), to: new Tile(Face.Back, [1,0])),
                  new IndexMove(from: new Tile(Face.Top, [0,2]), to: new Tile(Face.Back, [2,0]))
                ];

            IndexMove[] backMoves =
                [ new IndexMove(from: new Tile(Face.Back, [0,0]), to: new Tile(Face.Down, [2,2])),
                  new IndexMove(from: new Tile(Face.Back, [1,0]), to: new Tile(Face.Down, [1,2])),
                  new IndexMove(from: new Tile(Face.Back, [2,0]), to: new Tile(Face.Down, [0,2]))
                ];

            IndexMove[] downMoves =
                [ new IndexMove(from: new Tile(Face.Down, [0,2]), to: new Tile(Face.Front, [0,2])),
                  new IndexMove(from: new Tile(Face.Down, [1,2]), to: new Tile(Face.Front, [1,2])),
                  new IndexMove(from: new Tile(Face.Down, [2,2]), to: new Tile(Face.Front, [2,2]))
                ];

            IndexMove[] frontMoves =
                [ new IndexMove(from: new Tile(Face.Front, [0,2]), to: new Tile(Face.Top, [0,2])),
                  new IndexMove(from: new Tile(Face.Front, [1,2]), to: new Tile(Face.Top, [1,2])),
                  new IndexMove(from: new Tile(Face.Front, [2,2]), to: new Tile(Face.Top, [2,2]))
                ];
            return [faceMoves, topMoves, backMoves, downMoves, frontMoves];
        }

        private static IndexMove[][] BackSideMoves()
        {
            IndexMove[] faceMoves = FaceMoves(Face.Back);

            IndexMove[] topMoves =
                [ new IndexMove(from: new Tile(Face.Top, [0,2]), to: new Tile(Face.Left, [0,0])),
                  new IndexMove(from: new Tile(Face.Top, [0,1]), to: new Tile(Face.Left, [1,0])),
                  new IndexMove(from: new Tile(Face.Top, [0,0]), to: new Tile(Face.Left, [2,0]))
                ];

            IndexMove[] leftMoves =
                [ new IndexMove(from: new Tile(Face.Left, [0,0]), to: new Tile(Face.Down, [2,0])),
                  new IndexMove(from: new Tile(Face.Left, [1,0]), to: new Tile(Face.Down, [2,1])),
                  new IndexMove(from: new Tile(Face.Left, [2,0]), to: new Tile(Face.Down, [2,2]))
                ];

            IndexMove[] downMoves =
                [ new IndexMove(from: new Tile(Face.Down, [2,2]), to: new Tile(Face.Right, [0,2])),
                  new IndexMove(from: new Tile(Face.Down, [2,1]), to: new Tile(Face.Right, [1,2])),
                  new IndexMove(from: new Tile(Face.Down, [2,0]), to: new Tile(Face.Right, [2,2]))
                ];

            IndexMove[] rightMoves =
                [ new IndexMove(from: new Tile(Face.Right, [0, 2]), to: new Tile(Face.Top, [0,0])),
                  new IndexMove(from: new Tile(Face.Right, [1, 2]), to: new Tile(Face.Top, [0,1])),
                  new IndexMove(from: new Tile(Face.Right, [2, 2]), to: new Tile(Face.Top, [0,2]))
                ];
            return [faceMoves, topMoves, leftMoves, downMoves, rightMoves];
        }

        private static IndexMove[][] LeftSideMoves()
        {
            IndexMove[] faceMoves = FaceMoves(Face.Left);

            IndexMove[] topMoves =
                [ new IndexMove(from: new Tile(Face.Top, [0,0]), to: new Tile(Face.Front, [0,0])),
                  new IndexMove(from: new Tile(Face.Top, [1,0]), to: new Tile(Face.Front, [1,0])),
                  new IndexMove(from: new Tile(Face.Top, [2,0]), to: new Tile(Face.Front, [2,0]))
                ];

            IndexMove[] frontMoves =
                [ new IndexMove(from: new Tile(Face.Front, [0,0]), to: new Tile(Face.Down, [0,0])),
                  new IndexMove(from: new Tile(Face.Front, [1,0]), to: new Tile(Face.Down, [1,0])),
                  new IndexMove(from: new Tile(Face.Front, [2,0]), to: new Tile(Face.Down, [2,0]))
                ];

            IndexMove[] downMoves =
                [ new IndexMove(from: new Tile(Face.Down, [2,0]), to: new Tile(Face.Back, [0,2])),
                  new IndexMove(from: new Tile(Face.Down, [1,0]), to: new Tile(Face.Back, [1,2])),
                  new IndexMove(from: new Tile(Face.Down, [0,0]), to: new Tile(Face.Back, [2,2]))
                ];

            IndexMove[] backMoves =
                [ new IndexMove(from: new Tile(Face.Back, [0, 2]), to: new Tile(Face.Top, [2,0])),
                  new IndexMove(from: new Tile(Face.Back, [1, 2]), to: new Tile(Face.Top, [1,0])),
                  new IndexMove(from: new Tile(Face.Back, [2, 2]), to: new Tile(Face.Top, [0,0]))
                ];
            return [faceMoves, topMoves, frontMoves, downMoves, backMoves];
        }

        private static IndexMove[][] TopSideMoves()
        {
            IndexMove[] faceMoves = FaceMoves(Face.Top);

            IndexMove[] backMoves =
                [ new IndexMove(from: new Tile(Face.Back, [0,2]), to: new Tile(Face.Right, [0,2])),
                  new IndexMove(from: new Tile(Face.Back, [0,1]), to: new Tile(Face.Right, [0,1])),
                  new IndexMove(from: new Tile(Face.Back, [0,0]), to: new Tile(Face.Right, [0,0]))
                ];

            IndexMove[] rightMoves =
                [ new IndexMove(from: new Tile(Face.Right, [0,2]), to: new Tile(Face.Front, [0,2])),
                  new IndexMove(from: new Tile(Face.Right, [0,1]), to: new Tile(Face.Front, [0,1])),
                  new IndexMove(from: new Tile(Face.Right, [0,0]), to: new Tile(Face.Front, [0,0]))
                ];

            IndexMove[] frontMoves =
                [ new IndexMove(from: new Tile(Face.Front, [0,0]), to: new Tile(Face.Left, [0,0])),
                  new IndexMove(from: new Tile(Face.Front, [0,1]), to: new Tile(Face.Left, [0,1])),
                  new IndexMove(from: new Tile(Face.Front, [0,2]), to: new Tile(Face.Left, [0,2]))
                ];

            IndexMove[] leftMoves =
                [ new IndexMove(from: new Tile(Face.Left, [0,0]), to: new Tile(Face.Back, [0,0])),
                  new IndexMove(from: new Tile(Face.Left, [0,1]), to: new Tile(Face.Back, [0,1])),
                  new IndexMove(from: new Tile(Face.Left, [0,2]), to: new Tile(Face.Back, [0,2]))
                ];

            return [faceMoves, backMoves, rightMoves, frontMoves, leftMoves];
        }

        private static IndexMove[][] DownSideMoves()
        {
            IndexMove[] faceMoves = FaceMoves(Face.Down);

            IndexMove[] frontMoves =
                [ new IndexMove(from: new Tile(Face.Front, [2,0]), to: new Tile(Face.Right, [2,0])),
                  new IndexMove(from: new Tile(Face.Front, [2,1]), to: new Tile(Face.Right, [2,1])),
                  new IndexMove(from: new Tile(Face.Front, [2,2]), to: new Tile(Face.Right, [2,2]))
                ];

            IndexMove[] rightMoves =
                [ new IndexMove(from: new Tile(Face.Right, [2,0]), to: new Tile(Face.Back, [2,0])),
                  new IndexMove(from: new Tile(Face.Right, [2,1]), to: new Tile(Face.Back, [2,1])),
                  new IndexMove(from: new Tile(Face.Right, [2,2]), to: new Tile(Face.Back, [2,2]))
                ];

            IndexMove[] backMoves =
                [ new IndexMove(from: new Tile(Face.Back, [2,0]), to: new Tile(Face.Left, [2,0])),
                  new IndexMove(from: new Tile(Face.Back, [2,1]), to: new Tile(Face.Left, [2,1])),
                  new IndexMove(from: new Tile(Face.Back, [2,2]), to: new Tile(Face.Left, [2,2]))
                ];

            IndexMove[] leftMoves =
                [ new IndexMove(from: new Tile(Face.Left, [2,0]), to: new Tile(Face.Front, [2,0])),
                  new IndexMove(from: new Tile(Face.Left, [2,1]), to: new Tile(Face.Front, [2,1])),
                  new IndexMove(from: new Tile(Face.Left, [2,2]), to: new Tile(Face.Front, [2,2]))
                ];

            return [faceMoves, frontMoves, rightMoves, backMoves, leftMoves];
        }


        private static IndexMove[] FaceMoves(Face face)
        {
            return
                [ new IndexMove(from: new Tile(face, [0, 0]), to: new Tile(face, [0,2])),
                  new IndexMove(from: new Tile(face, [0, 1]), to: new Tile(face, [1,2])),
                  new IndexMove(from: new Tile(face, [0, 2]), to: new Tile(face, [2,2])),

                  new IndexMove(from: new Tile(face, [1, 0]), to: new Tile(face, [0,1])),
                  new IndexMove(from: new Tile(face, [1, 2]), to: new Tile(face, [2,1])),

                  new IndexMove(from: new Tile(face, [2, 0]), to: new Tile(face, [0,0])),
                  new IndexMove(from: new Tile(face, [2, 1]), to: new Tile(face, [1,0])),
                  new IndexMove(from: new Tile(face, [2, 2]), to: new Tile(face, [2,0]))
                ];
        }
    }
}