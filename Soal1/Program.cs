using System;

namespace Soal1
{
    public class Employee
    {
        protected string nama;
        protected int umur;

        public Employee(string Nama, int Umur)
        {
            this.nama = Nama;
            this.umur = Umur;
        }

        public string getName()
        {
            return this.nama;
        }

        public int getUmur()
        {
            return this.umur;
        }

        public void setName(string Nama)
        {
            this.nama = Nama;
        }

        public void setUmur(int Umur)
        {
            this.umur = Umur;
        }
        public void hola()
        {
            Console.WriteLine($"punten, perkenalkan saya {this.nama} umur {this.umur} adalah seorang pegawai");
        }
    }

    public class Staff : Employee
    {
        private string departemen;

        public Staff(string Nama, int Umur, string departemen) : base(Nama, Umur)
        {
            this.departemen = departemen;
        }
        public string getDepartemen()
        {
            return this.departemen;
        }
        public void setDepartemeen(string Departemen)
        {
            this.departemen = Departemen;
        }
        public void hola()
        {
            Console.WriteLine($"punten, perkenalkan saya {this.nama} umur {this.umur} adalah seorang staff di departemen {this.departemen}");
        }

    }

    public class Programmer: Employee
    {
        private string bahasaUtama;
        private string[] bahasaDikuasai;

        public Programmer(string Nama, int Umur, string BahasaUtama, string[] bahasaDikuasai) : base(Nama, Umur)
        {
            this.bahasaUtama = BahasaUtama;
            this.bahasaDikuasai = bahasaDikuasai;
        }
        public string getBahasaUtama()
        {
            return this.bahasaUtama;
        }
        public void setBahasaUtama(string BahasaUtama)
        {
            this.bahasaUtama = BahasaUtama;
        }
        public string[] getBahasaDikuasai()
        {
            return bahasaDikuasai;
        }
        public void setBahasaDisukai(string[] BahasaDisukai)
        {
            this.bahasaDikuasai = BahasaDisukai;
        }
        public void hola()
        {
            Console.Write($"punten, perkenalkan saya {this.getName()} umur {this.getUmur()} adalah seorang programmer master di bahasa {this.getBahasaUtama()}. selain itu saya bisa beberapa bahasa berikut: ");
            int len = bahasaDikuasai.Length;
            if (len > 1)
            {
                for (int i = 0; i < len -1; i++)
                {
                    Console.Write($" {this.bahasaDikuasai[i]},");
                }
                Console.WriteLine($" dan {this.bahasaDikuasai[len - 1]}");
            }
            else
            {
                Console.WriteLine(this.bahasaDikuasai[len - 1]);
            }
        }
    }

    public class Teacher : Employee
    {
        private string pelajaran;

        public Teacher(string Nama, int Umur, string Pelajaran) : base(Nama, Umur)
        {
            this.pelajaran = Pelajaran;
        }
        public void setPelajara(string Pelajaran)
        {
            this.pelajaran = Pelajaran;
        }
        public string getPelajaran()
        {
            return this.pelajaran;
        }
        public void hola()
        {
            Console.WriteLine($"punten, perkenalkan saya {this.getName()} umur {this.getUmur()} adalah seorang guru yang mengajar di pelajaran {this.getPelajaran()}");

        }

    }
    public class ItSec : Employee
    {
        string bidangSiber;
        public ItSec(string Nama, int Umur, string BidangSiber):base(Nama,Umur)
        {
            this.bidangSiber = BidangSiber;
        }
        public void setBidangSiber(string BidangSiber)
        {
            this.bidangSiber = BidangSiber;
        }
        public string getBidangSiber()
        {
            return this.bidangSiber;
        }
        public void hola()
        {
            Console.WriteLine($"punten, perkenalkan saya {this.getName()} umur {this.getUmur()} adalah seorang IT Security yang mengurus keamanan di ranah {this.getBidangSiber()}");

        }
    }
    public class DataScients : Employee
    {
        string bidangData;
        public DataScients(string Nama,int Umur, string BidangData) : base(Nama, Umur)
        {
            this.bidangData = BidangData;
        }
        public void setBidangData(string BidangData)
        {
            this.bidangData=BidangData;
        }
        public string getBidangdata()
        {
            return this.bidangData;
        }
        public void hola()
        {
            Console.WriteLine($"punten, perkenalkan saya {this.getName()} umur {this.getUmur()} adalah seorang Data Scients yang antusias di bidang {this.getBidangdata()}");

        }
    }

    public class Vehicle
    {
        public string platNomor;
        public string warna;
        public string merk;
        public Vehicle(string PlatNomor, string Warna, string Merk)
        {
            this.warna = Warna;
            this.platNomor = PlatNomor;
            this.merk = Merk;
        }
        public void setPlatNomor(string PlatNomor)
        {
            this.platNomor = PlatNomor;
        }
        public string getPlatNomor()
        {
            return this.platNomor;
        }
        public void setWarna(string Warna)
        {
            this.warna = Warna;
        }
        public string getWarna()
        {
            return this.warna;
        }
        public void setMerk(string Merk)
        {
            this.merk = Merk;
        }
        public string getMerk()
        {
            return this.merk;
        }
        public string desk()
        {
            return $"Kendaraan ini memiliki plat nomor polisi => '{this.getPlatNomor()}' dengan warna {this.merk}   {this.merk}";
        }
    }
    public class Car : Vehicle
    {
        
        public int kecepatan;
        public int dayaTampung;
        public Car(string PlatNomor, string Warna, string Merk, int Kecepatan, int DayaTampung) : base(PlatNomor, Warna, Merk)
        {
            this.kecepatan = Kecepatan;
            this.dayaTampung = DayaTampung;
        }
        public void setKecepatan(int Kecepatan)
        {
            this.kecepatan = Kecepatan;
        }
        public int getKecepatan()
        {
            return this.kecepatan;
        }
        public void setDataTampung(int DayaTampung)
        {
            this.dayaTampung= DayaTampung;
        }
        public int getDayaTampung()
        {
            return this.dayaTampung;
        }
        public string desk()
        {
            return $"Mobil merk {this.getMerk()} ini memiliki spesifikasi warna: {this.getWarna()}, kecepatan: {this.getKecepatan()} M/h, dan daya tampung sebanyak: {this.getDayaTampung()} orang";
        }
    }
    public class Truck : Vehicle
    {
        public int volumeBak;
        public Truck(string PlatNomor, string Warna, string Merk, int VolumeBak) : base(PlatNomor, Warna, Merk)
        {
            this.volumeBak = VolumeBak;
        }
        public void setVolumeBak(int VolumeBak)
        {
            this.volumeBak = VolumeBak;
        }
        public int getVolumeBak()
        {
            return this.volumeBak;
        }
        public string desk()
        {
            return $"Truk merk {this.getMerk()} ini memiliki plat nomor polisi {this.platNomor} warna {this.warna} dengan volume bak yang dapat menampung muatan sebanyak {this.volumeBak} meter kubik";
        }
    }
    public class Motor: Vehicle
    {
        public bool statusBonceng;
        public Motor(string PlatNomor, string Warna, String Merk, bool StatusBonceng): base(PlatNomor, Warna, Merk)
        {
            this.statusBonceng = StatusBonceng;
        }
        public void setStatusBonceng(bool StatusBonceng)
        {
            this.statusBonceng = StatusBonceng;
        }
        public string boncengKah()
        {
            if (this.statusBonceng == false)
            {
                return $"No... solo player";
            } else
            {
                return $"Yes.. bonceng someone";
            }
        }

    }
    public class Helikopter : Vehicle
    {
        public bool statusNaik;
        public Helikopter(string PlatNomor, string Warna, string Merk, bool StatusNaik):base(PlatNomor, Warna, Merk)
        {
            this.statusNaik = StatusNaik;
        }
        public void setStatusNaik(bool StatusNaik)
        {
            this.statusNaik = StatusNaik;
        }
        public string terbangKah()
        {
            if (this.statusNaik == false)
            {
                return $"No... sedang chilin di darat";
            } else
            {
                return $"yess... sedang mengudara";
            }
        }
    }
    public class Tank:Vehicle
    {
        public bool statusOperasi;
        public Tank(string PlatNomor, string Warna, string Merk, bool StatusOperasi):base(PlatNomor, Warna, Merk)
        {
            this.statusOperasi = StatusOperasi;
        }
        public void setStatusOperasi(bool StatusOperasi)
        {
            this.statusOperasi=StatusOperasi;
        }
        public string beroperasiKah()
        {
            if (this.statusOperasi == true)
            {
                return $"Yes... sedang perang di darat";
            }
            else
            {
                return $"No.. sedang chilin di pangkalan";
            }
        }
    }

    public class Animal
    {
        public string warna;
        public int jumlahKaki;
        public bool sejenisIkankah;

        public Animal(string Warna, int JumlahKaki,bool SejenisIkanKah)
        {
            this.warna = Warna;
            this.jumlahKaki = JumlahKaki;
            this.sejenisIkankah = SejenisIkanKah;
        }
        public void setWarna(string warna)
        {
            this.warna = warna;
        }
        public string getWarna()
        {
            return this.warna;
        }
        public void setJumlahkaki(int JumlahKaki)
        {
            if (!this.sejenisIkankah)
            {
                this.jumlahKaki = JumlahKaki;
            }
        }
        public int getJumlahKaki()
        {
            return this.jumlahKaki;
        }
        public void setSejenisIkanah(bool SejenisIkanKah)
        {
            this.sejenisIkankah = SejenisIkanKah;
        }
        public bool getSejenisIkahKah()
        {
            return this.sejenisIkankah;
        }
        public string berenangKah()
        {
            if (this.sejenisIkankah)
            {
                this.jumlahKaki = 0; // ikan tidak berkaki sepertinya:) entah kalau godzila :'
                return $"ya berenang";
            }
            else
            {
                return $"bisa jadi";
            }
        }
    }
    public class Kucing : Animal
    {
        public string jenis;
        public bool statusMeong;

        public Kucing(string Warna, int JumlahKaki, bool SejenisIkanKah, string Jenis, bool StatusMeong):base(Warna, JumlahKaki, SejenisIkanKah)
        {
            this.jenis = Jenis;
            this.statusMeong = StatusMeong;
        }
        public void setJenis(string Jenis)
        {
            this.jenis = Jenis;
        }
        public string getJenis()
        {
            return this.jenis;
        }
        public void setStatusMeong(bool StatusMeong)
        {
            this.statusMeong = StatusMeong;
        }
        public string lagiMeongKah()
        {
            if (this.statusMeong)
            {
                return $"meong meong meong";
            } else
            {
                return $"- - - - - - -  - - -";
            }
        }
        public string sapaan()
        {
            return "Meongg arghhh meongg arghh :)";
        }


    }

    public class Anjing : Animal
    {
        public bool pelacakKah;
        public Anjing(string Warna, int JumlahKaki, bool SejenisIkanKah, bool PelacakKah) : base(Warna, JumlahKaki, SejenisIkanKah)
        {
            this.pelacakKah = PelacakKah;
        }
        public void setStatusMelacak(bool StatusMelacak)
        {
            this.pelacakKah = StatusMelacak;
        }

        public string statusMelacak()
        {
            return (this.pelacakKah) ? "ya, bisa melacak" : "tidak bisa melacak";
        }
        public string sapaan()
        {
            return "guk guk guk guk :)";
        }
    }

    public class Bunglon: Animal
    {
        public bool sedangMenghilang;

        public Bunglon(string Warna, int JumlahKaki, bool SejenisIkanKah, bool SedangMenghilang) : base(Warna, JumlahKaki, SejenisIkanKah)
        {
            this.sedangMenghilang = SedangMenghilang;
        }
        public void setStatusMenghilang(bool StatusMenghilang)
        {
            this.sedangMenghilang = StatusMenghilang;
        }

        public string kelihatankah()
        {
            return (this.sedangMenghilang) ? "buset jurus menghilang": "Yap kelihatan jelas";
        }
    }
    public class Ular : Animal
    {
        public bool berbisa;
        public Ular(string Warna, int JumlahKaki, bool SejenisIkanKah, bool Berbisa):base(Warna, JumlahKaki, SejenisIkanKah)
        {
            this.berbisa = Berbisa;
        }
        public void setBerbisa(bool Berbisa)
        {
            this.berbisa= Berbisa; 
        }
        public string mematikanKah()
        {
            return (this.berbisa) ? "ya" : "tidak";
        }
    }

    public class Burung: Animal
    {
        public bool kemampuanTerbang;

        public Burung(string Warna, int JumlahKaki, bool SejenisIkanKah, bool KemampuanTerbang):base(Warna, JumlahKaki, SejenisIkanKah)
        {
            this.kemampuanTerbang = KemampuanTerbang;
        }
        public void setKemampuanTerbang(bool KemampuanTerbang)
        {
            this.kemampuanTerbang= KemampuanTerbang;
        }
        public string cekKemampuanTerbang()
        {
            return (this.kemampuanTerbang) ? "Ya bisa terbang" : "tidak bisa terbang";
        }
    }
    public class Progam
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================================>  Pegawai  <======================================");
            Employee employee1 = new Employee("yusuf", 24);
            employee1.hola();
            Staff staff1 = new Staff("renal", 12, "Keuangan");
            staff1.hola();
            Programmer programmer1 = new Programmer("rudin", 21, "CPP", new string[] {"CPP","Python","Golang","Java","Rust"});
            programmer1.hola();
            Teacher teacher1 = new Teacher("Sri", 34, "Matematika");
            teacher1.setUmur(30);
            teacher1.hola();
            ItSec ItSec1 = new ItSec("Elliot", 28, "Malware Analyst");
            ItSec1.hola();
            DataScients Dt1 = new DataScients("Rara", 45, "Deep Learning");
            Dt1.hola();
            Console.WriteLine("========================================================================================");
            Console.WriteLine();
            Console.WriteLine("====================================>   Kendaraan   <=======================================");
            
            Vehicle kendaraan1 = new Vehicle("P 2452 xx", "Biru", "Beat mesra");
            Console.WriteLine(kendaraan1.desk());

            Car mobil1 = new Car("P 2222 xx", "hitam","Jazz", 200, 6);
            Console.WriteLine(mobil1.desk());

            Truck truk1 = new Truck("AB 2001 xa","hitam", "fuso", 50 );
            Console.WriteLine(truk1.desk());

            Motor motor1 = new Motor("AB 0913 ad", "merah", "Supra geter", false);
            Console.WriteLine(motor1.boncengKah());

            Helikopter helikopter1 = new Helikopter("D 1241 sd","Putih","Eurocopter",true);
            Console.WriteLine(helikopter1.terbangKah());
            helikopter1.setStatusNaik(false);
            Console.WriteLine(helikopter1.terbangKah());

            Tank tank1 = new Tank("AR 4515 js", "Hijau", "Panser", true);
            Console.WriteLine(tank1.beroperasiKah());

            Console.WriteLine("========================================================================================");
            Console.WriteLine();
            Console.WriteLine("====================================>   Hewan   <=======================================");

            Animal animal1 = new Animal("abu abu", 4, false);
            Console.WriteLine(animal1.berenangKah());
            animal1.setSejenisIkanah(true);
            Console.WriteLine(animal1.berenangKah());

            Kucing kucing1 = new Kucing("oren", 4, false, "mogie", true);
            Console.WriteLine(kucing1.berenangKah());
            Console.WriteLine(kucing1.sapaan());
            Console.WriteLine(kucing1.lagiMeongKah());
            kucing1.setStatusMeong(false);
            Console.WriteLine(kucing1.lagiMeongKah());

            Anjing anjing1 = new Anjing("hitam", 4, false, true);
            Console.WriteLine(anjing1.statusMelacak());

            Bunglon bunglon1 = new Bunglon("hijau",4,false, false);
            Console.WriteLine(bunglon1.kelihatankah());
            bunglon1.setStatusMenghilang(true);
            Console.WriteLine(bunglon1.kelihatankah());

            Ular ular1 = new Ular("Putih", 0, false, true);
            Console.WriteLine(ular1.mematikanKah());

            Burung burung1 = new Burung("Hitam", 2, false, false); // burung unta tidak bisa terbang
            Console.WriteLine(burung1.cekKemampuanTerbang());
        }
    }
}