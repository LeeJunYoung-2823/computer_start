using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        try
        {
            string note1 = @"C:\Users\sweetbook15\Desktop\작업내용.txt";
            string note2 = @"C:\Users\sweetbook15\Desktop\메모.txt";
            string note3 = @"C:\Users\sweetbook15\Desktop\cs 업무 메모.txt";

            string folder1 = @"D:\원격";
            string folder2 = @"D:\";
            string folder3 = @"C:\Users\sweetbook15\Downloads";

            string excelFile1 = @"D:\업무관련\업무 관련 내용 정리.xlsx";
            string excelFile2 = @"D:\업무관련\앱 업데이트 현황.xlsx";
            string excelFile3 = @"D:\업무관련\스위트북 모니터링.xlsx";

            string browser1 = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";
            string browser2 = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";

            string program1 = @"C:\SMYSoft\SMemo\SMemo.exe";

            // 엑셀 프로그램 경로
            string excelAppPath = @"C:\Program Files\Microsoft Office 15\root\office15\EXCEL.EXE";
            ProcessStartInfo psi = new ProcessStartInfo(excelAppPath);


            // 파일 열기
            Process.Start("Notepad.exe", note1);
            Process.Start("Notepad.exe", note2);
            Process.Start("Notepad.exe", note3);

            // 엑셀 열기
            psi.Arguments = "\"" + excelFile1 + "\"";
            Process.Start(psi);
            psi.Arguments = "\"" + excelFile2 + "\"";
            Process.Start(psi);
            psi.Arguments = "\"" + excelFile3 + "\"";
            Process.Start(psi);

            // 폴더 열기
            Process.Start(Environment.GetEnvironmentVariable("WINDIR") +
                @"\explorer.exe", folder1);
            Process.Start(Environment.GetEnvironmentVariable("WINDIR") +
                @"\explorer.exe", folder2);
            Process.Start(Environment.GetEnvironmentVariable("WINDIR") +
                @"\explorer.exe", folder3);

            // 브라우저 열기
            Process.Start(browser1);
            Process.Start(browser2);

            // 프로그램 실행
            Process.Start(program1);
        } catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}