using RubiksCube.Models;
using RubiksCube.Enums;
using RubiksCube.Services;

namespace RubiksCube.UnitTests;

[TestClass]
public sealed class RotationTests
{

    public required Cube BaseCube;

    [TestInitialize]
    public void Prepare()
    {
        BaseCube = TestUtilities.CreateBaseCube();
    }

    [TestMethod]
    public void Test_Rotation_F_Front_Clockwise()
    {
        CubeRotationModel model = new()
        {
            Cube = BaseCube,
            Direction = Move.F
        };
        RotationService.Rotate(model);
        TestUtilities.CompareColours(BaseCube, TestUtilities.FRotatedCube);
    }

    [TestMethod]
    public void Test_Rotation_RPrime_Right_AntiClockwise()
    {
        CubeRotationModel model = new()
        {
            Cube = BaseCube,
            Direction = Move.RPrime
        };
        RotationService.Rotate(model);
        TestUtilities.CompareColours(BaseCube, TestUtilities.RPrimeRotatedCube);
    }

    [TestMethod]
    public void Test_Rotation_U_Up_Clockwise()
    {
        CubeRotationModel model = new()
        {
            Cube = BaseCube,
            Direction = Move.U
        };
        RotationService.Rotate(model);
        TestUtilities.CompareColours(BaseCube, TestUtilities.URotatedCube);
    }

    [TestMethod]
    public void Test_Rotation_BPrime_Back_AntiClockwise()
    {
        CubeRotationModel model = new()
        {
            Cube = BaseCube,
            Direction = Move.BPrime
        };
        RotationService.Rotate(model);
        TestUtilities.CompareColours(BaseCube, TestUtilities.BPrimeRotatedCube);
    }


    [TestMethod]
    public void Test_Rotation_L_Left_Clockwise()
    {
        CubeRotationModel model = new()
        {
            Cube = BaseCube,
            Direction = Move.L
        };
        RotationService.Rotate(model);
        TestUtilities.CompareColours(BaseCube, TestUtilities.LRotatedCube);
    }


    [TestMethod]
    public void Test_Rotation_DPrime_Down_AntiClockwise()
    {
        CubeRotationModel model = new()
        {
            Cube = BaseCube,
            Direction = Move.DPrime
        };
        RotationService.Rotate(model);
        TestUtilities.CompareColours(BaseCube, TestUtilities.DPrimeRotatedCube);
    }

    [TestMethod]
    public void Test_Combination()
    {
        //F
        RotationService.Rotate(new() { Cube = BaseCube, Direction = Move.F });
        //R'
        RotationService.Rotate(new() { Cube = BaseCube, Direction = Move.RPrime });
        //U
        RotationService.Rotate(new() { Cube = BaseCube, Direction = Move.U });
        //B'
        RotationService.Rotate(new() { Cube = BaseCube, Direction = Move.BPrime });
        //L
        RotationService.Rotate(new() { Cube = BaseCube, Direction = Move.L });
        //D'
        RotationService.Rotate(new() { Cube = BaseCube, Direction = Move.DPrime });

        TestUtilities.CompareColours(BaseCube, TestUtilities.CombinedRotatedCube);
    }
}
