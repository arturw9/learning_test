using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Tests
{
    public static class WorldsDumbestFunctionTests
    {
        //Naming Convention - ClassName_MethodName_ExepctedResult
        public static void WorldsDumbestFunction_ReturnsPikachuIfZero_ReturnString()
        {
            try
            {
                int num = 0;

                WorldsDumbesFunction worldsDumbesFunction = new WorldsDumbesFunction();

                string result = worldsDumbesFunction.ReturnsPikachuIfZero(num);

                if (result == "PIKACHU!")
                {
                    Console.WriteLine("PASSED: WorldsDumbestFunction_ReturnsPikachuIfZero_ReturnString");
                }
                else
                {
                    Console.WriteLine("FAILED: WorldsDumbestFunction_ReturnsPikachuIfZero_ReturnString");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}