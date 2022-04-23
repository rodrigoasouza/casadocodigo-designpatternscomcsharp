using System.ComponentModel;

namespace Design.Patterns.Creational.Factory_Method.Character.Enums
{
    public enum Characters
    {
        [Description]
        Null = 0,
        [Description("Liu Kang")]
        LiuKang = 1,
        [Description("Sub-Zero")]
        SubZero = 2,
        [Description("Shang Tsung")]
        ShangTsung = 3
    }
}
