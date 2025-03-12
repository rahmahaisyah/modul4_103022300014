using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4
{
    public class FanLaptop
    {
        //global variabel mengangkut tiap state
        public enum State {Quiet, Balance, Performance, Turbo }
        public enum Triger {Mode_Up, Mode_Down, Turbo_Shortcut}
        public State now = State.Quiet;

        public class Transition
        {
            public State awal;
            public State akhir;
            //untuk menyimpan pemicu state
            public Triger triger;

            public Transition(State first, State last, Triger trigerr)
            {
                awal = first;
                akhir = last;
                triger = trigerr;
            }
        }

        //meyimpan dalam array untuk perubahan kondisi skema Quiet, Balance
        //ModeUP, Performace, Turbo, ModeDOWN,  Turbo sortcut
        public Transition[] transisi =
        {
                new Transition(State.Quiet, State.Balance, Triger.Mode_Up),
                new Transition(State.Balance, State.Quiet, Triger.Mode_Down),
                new Transition(State.Balance, State.Performance, Triger.Mode_Up),
                new Transition(State.Performance, State.Balance, Triger.Mode_Down),
                new Transition(State.Quiet, State.Turbo, Triger.Turbo_Shortcut),
                new Transition(State.Turbo, State.Quiet, Triger.Turbo_Shortcut),
                new Transition(State.Turbo, State.Performance, Triger.Mode_Down),
                new Transition(State.Performance, State.Turbo, Triger.Mode_Up),
            };

        //fungsi untuk mencari state perpindahan dari triger yang ada, dengan pemicu pengkondisian
        public State GetNext(State first, Triger triger)
        {
            //perulangan untuk mengecek keseluruhan  transisi
            foreach (Transition transition in transisi)
            {
                if (first == transition.awal && triger == transition.triger)
                {
                    return transition.akhir;
                }
            }
            return first;
        }

        //fungsi untuk mengaktifkan triger untuk perpindahan state, untuk mengganti state current menjadi
        //state next
        public void aktif(Triger triger)
        {
            State prev = now;
            now = GetNext(now, triger);
            Console.WriteLine($"{prev} berubah menjadi {now}");
        }
        //membuat metode untu tiap state
        public void Mode_Up()
        {
            aktif(Triger.Mode_Up);
        }
        public void Mode_Down()
        {
            aktif(Triger.Mode_Down);
        }
        public void Turbo_Shortcut()
        {
            aktif(Triger.Turbo_Shortcut);
        }
        public void Mode_Down2()
        {
            aktif(Triger.Mode_Down);
        }
        public void Mode_Up2()
        {
            aktif(Triger.Mode_Up);
        }
    }
}
