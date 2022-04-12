using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class C
    {
        double height;
        double weight;

        Gender gender;
        Category category;
        Ability abilities;
        string image;
        Type type;
        Type weaknesses;

        enum Gender{
            male,
            female
        }
        enum Category{
            mouse
        }
        enum Ability{
            static_
        }
        enum Type{
            fire,water,ground,rock
        }
    }
}
