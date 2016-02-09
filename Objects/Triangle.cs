using System.Collections.Generic;

namespace Triangles.Objects
{
  public class Triangle
  {
    private int _side1;
    private int _side2;
    private int _side3;
    // private string _triangleType;

    public Triangle(int SetSide1, int SetSide2, int SetSide3)
    {
      _side1 = SetSide1;
      _side2 = SetSide2;
      _side3 = SetSide3;
    }
    public void SetSide1(int triangleSide1)
    {
      _side1 = triangleSide1;
    }
    public int GetSide1()
    {
      return _side1;
    }
    public void SetSide2(int triangleSide2)
    {
      _side2 = triangleSide2;
    }
    public int GetSide2()
    {
      return _side2;
    }
    public void SetSide3(int triangleSide3)
    {
      _side3 = triangleSide3;
    }
    public int GetSide3()
    {
      return _side3;
    }

    public string TriangleType()
    {
      if(_side1 < (_side2 + _side3) && _side2 < (_side3 + _side1) && _side3 < (_side1 + _side2))
      {
        if (_side1 == _side2 && _side2 == _side3)
        {
          return "equalateral";
        }
        else if (_side1 == _side2 || _side1 == _side3 || _side3 == _side2)
        {
          return "isosceles";
        }
        else
        {
          return "scalene";
        }
      }
      else
      {
        return "This is not a triangle";
      }
    }
  }
}
