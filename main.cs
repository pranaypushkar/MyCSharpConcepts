using System;
using Rotation;

class Program {
  public static void Main (string[] args) {

    RightArrayRotation r = new RightArrayRotation();
    r.Rotate1();
    r.Rotate2();

    LeftArrayRotation l = new LeftArrayRotation();
    l.Rotate1();
    l.Rotate2();
  }
}