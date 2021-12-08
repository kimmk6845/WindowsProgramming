using System;
using System.Windows.Forms;  // 추가
namespace ch9_Console_WinForm
{
    class ApplicationApp : Form
    {
        static void Main(string[] args)
        {
            ApplicationApp form = new ApplicationApp();

            // 델리게이트  -- 이벤트 처리기에 이벤트 연결
            form.Click += new EventHandler((sender, eventArgs) =>
            {
                // 호출된 폼을 클릭하면 Application.Exit(); 를 호출함.
                Console.WriteLine("Closing Window");  // [2]
                Application.Exit();  // 윈폼 닫음
            });
            Console.WriteLine("Starting Window Application");  // [1]
            Application.Run(form);  // 윈폼 실행 - 현재 윈도우 폼 호출 

            Console.WriteLine("Exiting Window Application");  // [3]
        }
    }
}
