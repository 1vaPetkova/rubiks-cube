namespace RubiksCube.Services;

using RubiksCube.Enums;
using RubiksCube.Models;

public static class RotationService
{
    public static void Rotate(CubeRotationModel model)
    {
        switch (model.Direction)
        {
            case Move.F: RotateFront(model); break;
            case Move.FPrime: RotateFrontPrime(model); break;
            case Move.R: RotateFrontPrime(model); break;
            case Move.RPrime: RotateFrontPrime(model); break;
            case Move.U: RotateFrontPrime(model); break;
            case Move.UPrime: RotateFrontPrime(model); break;
            case Move.B: RotateFrontPrime(model); break;
            case Move.BPrime: RotateFrontPrime(model); break;
            case Move.L: RotateFrontPrime(model); break;
            case Move.LPrime: RotateFrontPrime(model); break;
            case Move.D: RotateFrontPrime(model); break;
            case Move.DPrime: RotateFrontPrime(model); break;
        }
    }

    private static void RotateFront(CubeRotationModel model)
    {
        CubeModel cube = model.Cube;


    }

    private static void RotateFrontPrime(CubeRotationModel cube)
    {


    }
}