using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook
{
    class Cooker
    {
        static void Main(string[] args)
        {
            string[] people = new string[5]; //참가자
            int winner = 0; //우승자 번호
            int best = 0; // 가장높은 점수
            int sum; // 점수의 합계

            for (int i = 0; i <= 4; i++)
            {
                people[i] = Console.ReadLine(); // 점수입력
                char[] a = people[i].ToCharArray(); // 문자열로 입력받은 점수를 점수와 공백으로 나누기


                /*  문자를 숫자로 변환하는 코드를 구현해보려고했으나 구현하지 못하였음
               int result1, result2, result3, result4;
               result1 = Convert.ToInt32(a[0]); //1번째 평가
               result2 = Convert.ToInt32(a[2]); //2번째 평가
               result3 = Convert.ToInt32(a[4]); //3번째 평가
               result4 = Convert.ToInt32(a[6]); //4번째 평가
               sum = result1 + result2 + result3 + result4;  */
  

                sum = (a[0]-48) + (a[2]-48) + (a[4]-48) + (a[6]-48);  
                // ex) 입력 된 평가점수가 5 -> 53과 같이 48 크게 나오므로 직접 -48을 빼줌

                if (sum > best) // 점수의 합이 최고 값보다 크면 그 점수를 best에 대입
                {
                    best = sum;
                    winner = (i + 1);  // 배열 인덱스가 0부터 시작이므로 +1을 해주었음.
                }
            }

            Console.Write("{0} {1}\n", winner, best); //출력
   
        }

    }

}
