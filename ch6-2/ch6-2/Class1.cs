// Class1.cs
using System;
namespace ch6_파생클래스
{
    class 부모
    {
        public void Say()
        {
            Console.WriteLine("부모가 말하다.");
        }

        public void Hi()
        {
            Console.WriteLine("부모가 인사하다.");
        }

        public virtual void Run()       //미리 자식에게 다시 정의해서 쓰라고 알려주는 virtual
        {
            Console.WriteLine("부모가 달린다");
        }
    }
    class 자식 : 부모
    {
        // null

        public void Say()       //이건 버르장머리없는 형식으로 쓰는거임(****경고 발생****)
        {
            Console.WriteLine("자식이 말하다.");
        }

        public new void Hi()        //void 앞에 new를 붙혀줌으로 예의를 차리는 것
        {
            Console.WriteLine("자식이 인사하다.");
        }

        public override void Run()      //부모가 알려준데로 재정의해서 사용 (부모가 관대)
        {
            Console.WriteLine("자식이 달린다");
        }

    }
}
