using System;
using CompetentResponse;
using CompetentResponse.Message;
using Sample.Logics.User.Update;

namespace Sample
{
    class Program
    {
        static void Main(string[] args) {
            var logic = new UserUpdateInteractor();
            var successResponse = logic.Handle(new UserUpdateRequest("id", "test"));
            printResult(successResponse);

            var failResponse = logic.Handle(new UserUpdateRequest("id", "@"));
            printResult(failResponse);

            Console.WriteLine("===========================");
            Console.ReadKey();
        }

        private static void printResult<TErrorCode>(Response<TErrorCode> response) {
            Console.WriteLine("------------------------");
            if (response.HasError()) {
                Console.WriteLine("Error:");
                Console.WriteLine(response.ToErrorMessage());
            } else {
                Console.WriteLine("Success");
            }
        }
    }
}
