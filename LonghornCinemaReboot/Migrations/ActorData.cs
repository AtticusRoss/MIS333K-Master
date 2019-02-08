using LonghornCinemaReboot.DAL;
using LonghornCinemaReboot.Models;
using LonghornCinemaReboot.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;

namespace LonghornCinemaReboot.Migrations
{
    public class ActorData
    {
        public void SeedActors(AppDbContext db)
        {
            /*}
        }
    }*/

            Actor actor1 = new Actor();
            actor1.ActorName = "Warner Baxter";
            db.Actors.AddOrUpdate(g => g.ActorName, actor1);
            db.SaveChanges();

            Actor actor2 = new Actor();
            actor2.ActorName = "Bebe Daniels";
            db.Actors.AddOrUpdate(g => g.ActorName, actor2);
            db.SaveChanges();

            Actor actor3 = new Actor();
            actor3.ActorName = "George Brent";
            db.Actors.AddOrUpdate(g => g.ActorName, actor3);
            db.SaveChanges();

            Actor actor4 = new Actor();
            actor4.ActorName = "Ruby Keeler";
            db.Actors.AddOrUpdate(g => g.ActorName, actor4);
            db.SaveChanges();

            Actor actor5 = new Actor();
            actor5.ActorName = "Guy Kibbee";
            db.Actors.AddOrUpdate(g => g.ActorName, actor5);
            db.SaveChanges();

            Actor actor6 = new Actor();
            actor6.ActorName = "Una Merkel";
            db.Actors.AddOrUpdate(g => g.ActorName, actor6);
            db.SaveChanges();

            Actor actor7 = new Actor();
            actor7.ActorName = "Clark Gable";
            db.Actors.AddOrUpdate(g => g.ActorName, actor7);
            db.SaveChanges();

            Actor actor8 = new Actor();
            actor8.ActorName = "Claudette Colbert";
            db.Actors.AddOrUpdate(g => g.ActorName, actor8);
            db.SaveChanges();

            Actor actor9 = new Actor();
            actor9.ActorName = "Walter Connolly";
            db.Actors.AddOrUpdate(g => g.ActorName, actor9);
            db.SaveChanges();

            Actor actor10 = new Actor();
            actor10.ActorName = "Roscoe Karns";
            db.Actors.AddOrUpdate(g => g.ActorName, actor10);
            db.SaveChanges();

            Actor actor11 = new Actor();
            actor11.ActorName = "Jameson Thomas";
            db.Actors.AddOrUpdate(g => g.ActorName, actor11);
            db.SaveChanges();

            Actor actor12 = new Actor();
            actor12.ActorName = "Alan Hale";
            db.Actors.AddOrUpdate(g => g.ActorName, actor12);
            db.SaveChanges();

            Actor actor13 = new Actor();
            actor13.ActorName = "Adriana Caselotti";
            db.Actors.AddOrUpdate(g => g.ActorName, actor13);
            db.SaveChanges();

            Actor actor14 = new Actor();
            actor14.ActorName = "Lucille La Verne";
            db.Actors.AddOrUpdate(g => g.ActorName, actor14);
            db.SaveChanges();

            Actor actor15 = new Actor();
            actor15.ActorName = "Harry Stockwell";
            db.Actors.AddOrUpdate(g => g.ActorName, actor15);
            db.SaveChanges();

            Actor actor16 = new Actor();
            actor16.ActorName = "Roy Atwell";
            db.Actors.AddOrUpdate(g => g.ActorName, actor16);
            db.SaveChanges();

            Actor actor17 = new Actor();
            actor17.ActorName = "Pinto Colvig";
            db.Actors.AddOrUpdate(g => g.ActorName, actor17);
            db.SaveChanges();

            Actor actor18 = new Actor();
            actor18.ActorName = "Otis Harlan";
            db.Actors.AddOrUpdate(g => g.ActorName, actor18);
            db.SaveChanges();

            Actor actor19 = new Actor();
            actor19.ActorName = "Judy Garland";
            db.Actors.AddOrUpdate(g => g.ActorName, actor19);
            db.SaveChanges();

            Actor actor20 = new Actor();
            actor20.ActorName = "Frank Morgan";
            db.Actors.AddOrUpdate(g => g.ActorName, actor20);
            db.SaveChanges();

            Actor actor21 = new Actor();
            actor21.ActorName = "Ray Bolger";
            db.Actors.AddOrUpdate(g => g.ActorName, actor21);
            db.SaveChanges();

            Actor actor22 = new Actor();
            actor22.ActorName = "Bert Lahr";
            db.Actors.AddOrUpdate(g => g.ActorName, actor22);
            db.SaveChanges();

            Actor actor23 = new Actor();
            actor23.ActorName = "Jack Haley";
            db.Actors.AddOrUpdate(g => g.ActorName, actor23);
            db.SaveChanges();

            Actor actor24 = new Actor();
            actor24.ActorName = "Billie Burke";
            db.Actors.AddOrUpdate(g => g.ActorName, actor24);
            db.SaveChanges();

            Actor actor25 = new Actor();
            actor25.ActorName = "James Stewart";
            db.Actors.AddOrUpdate(g => g.ActorName, actor25);
            db.SaveChanges();

            Actor actor26 = new Actor();
            actor26.ActorName = "Jean Arthur";
            db.Actors.AddOrUpdate(g => g.ActorName, actor26);
            db.SaveChanges();

            Actor actor27 = new Actor();
            actor27.ActorName = "Claude Rains";
            db.Actors.AddOrUpdate(g => g.ActorName, actor27);
            db.SaveChanges();

            Actor actor28 = new Actor();
            actor28.ActorName = "Edward Arnold";
            db.Actors.AddOrUpdate(g => g.ActorName, actor28);
            db.SaveChanges();

            Actor actor29 = new Actor();
            actor29.ActorName = "Thomas Mitchell";
            db.Actors.AddOrUpdate(g => g.ActorName, actor29);
            db.SaveChanges();

            Actor actor30 = new Actor();
            actor30.ActorName = "Vivien Leigh";
            db.Actors.AddOrUpdate(g => g.ActorName, actor30);
            db.SaveChanges();

            Actor actor31 = new Actor();
            actor31.ActorName = "Olivia de Havilland";
            db.Actors.AddOrUpdate(g => g.ActorName, actor31);
            db.SaveChanges();

            Actor actor32 = new Actor();
            actor32.ActorName = "Leslie Howard";
            db.Actors.AddOrUpdate(g => g.ActorName, actor32);
            db.SaveChanges();

            Actor actor33 = new Actor();
            actor33.ActorName = "Barbara O'Neil";
            db.Actors.AddOrUpdate(g => g.ActorName, actor33);
            db.SaveChanges();

            Actor actor34 = new Actor();
            actor34.ActorName = "Humphrey Bogart";
            db.Actors.AddOrUpdate(g => g.ActorName, actor34);
            db.SaveChanges();

            Actor actor35 = new Actor();
            actor35.ActorName = "Ingrid Bergman";
            db.Actors.AddOrUpdate(g => g.ActorName, actor35);
            db.SaveChanges();

            Actor actor36 = new Actor();
            actor36.ActorName = "Paul Henreid";
            db.Actors.AddOrUpdate(g => g.ActorName, actor36);
            db.SaveChanges();

            Actor actor37 = new Actor();
            actor37.ActorName = "Conrad Veidt";
            db.Actors.AddOrUpdate(g => g.ActorName, actor37);
            db.SaveChanges();

            Actor actor38 = new Actor();
            actor38.ActorName = "Sydney Greenstreet";
            db.Actors.AddOrUpdate(g => g.ActorName, actor38);
            db.SaveChanges();

            Actor actor39 = new Actor();
            actor39.ActorName = "Donna Reed";
            db.Actors.AddOrUpdate(g => g.ActorName, actor39);
            db.SaveChanges();

            Actor actor40 = new Actor();
            actor40.ActorName = "Lionel Barrymore";
            db.Actors.AddOrUpdate(g => g.ActorName, actor40);
            db.SaveChanges();

            Actor actor41 = new Actor();
            actor41.ActorName = "Henry Travers";
            db.Actors.AddOrUpdate(g => g.ActorName, actor41);
            db.SaveChanges();

            Actor actor42 = new Actor();
            actor42.ActorName = "Beulah Bondi";
            db.Actors.AddOrUpdate(g => g.ActorName, actor42);
            db.SaveChanges();

            Actor actor43 = new Actor();
            actor43.ActorName = "Betty Hutton";
            db.Actors.AddOrUpdate(g => g.ActorName, actor43);
            db.SaveChanges();

            Actor actor44 = new Actor();
            actor44.ActorName = "Howard Keel";
            db.Actors.AddOrUpdate(g => g.ActorName, actor44);
            db.SaveChanges();

            Actor actor45 = new Actor();
            actor45.ActorName = "Louis Calhern";
            db.Actors.AddOrUpdate(g => g.ActorName, actor45);
            db.SaveChanges();

            Actor actor46 = new Actor();
            actor46.ActorName = "J. Carrol Naish";
            db.Actors.AddOrUpdate(g => g.ActorName, actor46);
            db.SaveChanges();

            Actor actor47 = new Actor();
            actor47.ActorName = "Keenan Wynn";
            db.Actors.AddOrUpdate(g => g.ActorName, actor47);
            db.SaveChanges();

            Actor actor48 = new Actor();
            actor48.ActorName = "Marlon Brando";
            db.Actors.AddOrUpdate(g => g.ActorName, actor48);
            db.SaveChanges();

            Actor actor49 = new Actor();
            actor49.ActorName = "Kim Hunter";
            db.Actors.AddOrUpdate(g => g.ActorName, actor49);
            db.SaveChanges();

            Actor actor50 = new Actor();
            actor50.ActorName = "Karl Malden";
            db.Actors.AddOrUpdate(g => g.ActorName, actor50);
            db.SaveChanges();

            Actor actor51 = new Actor();
            actor51.ActorName = "Rudy Bond";
            db.Actors.AddOrUpdate(g => g.ActorName, actor51);
            db.SaveChanges();

            Actor actor52 = new Actor();
            actor52.ActorName = "Nick Dennis";
            db.Actors.AddOrUpdate(g => g.ActorName, actor52);
            db.SaveChanges();

            Actor actor53 = new Actor();
            actor53.ActorName = "Gene Kelly";
            db.Actors.AddOrUpdate(g => g.ActorName, actor53);
            db.SaveChanges();

            Actor actor54 = new Actor();
            actor54.ActorName = "Donald O'Connor";
            db.Actors.AddOrUpdate(g => g.ActorName, actor54);
            db.SaveChanges();

            Actor actor55 = new Actor();
            actor55.ActorName = "Debbie Reynolds";
            db.Actors.AddOrUpdate(g => g.ActorName, actor55);
            db.SaveChanges();

            Actor actor56 = new Actor();
            actor56.ActorName = "Jean Hagen";
            db.Actors.AddOrUpdate(g => g.ActorName, actor56);
            db.SaveChanges();

            Actor actor57 = new Actor();
            actor57.ActorName = "Millard Mitchell";
            db.Actors.AddOrUpdate(g => g.ActorName, actor57);
            db.SaveChanges();

            Actor actor58 = new Actor();
            actor58.ActorName = "Cyd Charisse";
            db.Actors.AddOrUpdate(g => g.ActorName, actor58);
            db.SaveChanges();

            Actor actor59 = new Actor();
            actor59.ActorName = "Elizabeth Taylor";
            db.Actors.AddOrUpdate(g => g.ActorName, actor59);
            db.SaveChanges();

            Actor actor60 = new Actor();
            actor60.ActorName = "Paul Newman";
            db.Actors.AddOrUpdate(g => g.ActorName, actor60);
            db.SaveChanges();

            Actor actor61 = new Actor();
            actor61.ActorName = "Burl Ives";
            db.Actors.AddOrUpdate(g => g.ActorName, actor61);
            db.SaveChanges();

            Actor actor62 = new Actor();
            actor62.ActorName = "Judith Anderson";
            db.Actors.AddOrUpdate(g => g.ActorName, actor62);
            db.SaveChanges();

            Actor actor63 = new Actor();
            actor63.ActorName = "Jack Carson";
            db.Actors.AddOrUpdate(g => g.ActorName, actor63);
            db.SaveChanges();

            Actor actor64 = new Actor();
            actor64.ActorName = "Madeleine Sherwood";
            db.Actors.AddOrUpdate(g => g.ActorName, actor64);
            db.SaveChanges();

            Actor actor65 = new Actor();
            actor65.ActorName = "Marilyn Monroe";
            db.Actors.AddOrUpdate(g => g.ActorName, actor65);
            db.SaveChanges();

            Actor actor66 = new Actor();
            actor66.ActorName = "Tony Curtis";
            db.Actors.AddOrUpdate(g => g.ActorName, actor66);
            db.SaveChanges();

            Actor actor67 = new Actor();
            actor67.ActorName = "Jack Lemmon";
            db.Actors.AddOrUpdate(g => g.ActorName, actor67);
            db.SaveChanges();

            Actor actor68 = new Actor();
            actor68.ActorName = "George Raft";
            db.Actors.AddOrUpdate(g => g.ActorName, actor68);
            db.SaveChanges();

            Actor actor69 = new Actor();
            actor69.ActorName = "Pat O'Brien";
            db.Actors.AddOrUpdate(g => g.ActorName, actor69);
            db.SaveChanges();

            Actor actor70 = new Actor();
            actor70.ActorName = "Joe E. Brown";
            db.Actors.AddOrUpdate(g => g.ActorName, actor70);
            db.SaveChanges();

            Actor actor71 = new Actor();
            actor71.ActorName = "Anthony Perkins";
            db.Actors.AddOrUpdate(g => g.ActorName, actor71);
            db.SaveChanges();

            Actor actor72 = new Actor();
            actor72.ActorName = "Vera Miles";
            db.Actors.AddOrUpdate(g => g.ActorName, actor72);
            db.SaveChanges();

            Actor actor73 = new Actor();
            actor73.ActorName = "John Gavin";
            db.Actors.AddOrUpdate(g => g.ActorName, actor73);
            db.SaveChanges();

            Actor actor74 = new Actor();
            actor74.ActorName = "Janet Leigh";
            db.Actors.AddOrUpdate(g => g.ActorName, actor74);
            db.SaveChanges();

            Actor actor75 = new Actor();
            actor75.ActorName = "Martin Balsam";
            db.Actors.AddOrUpdate(g => g.ActorName, actor75);
            db.SaveChanges();

            Actor actor76 = new Actor();
            actor76.ActorName = "John McIntire";
            db.Actors.AddOrUpdate(g => g.ActorName, actor76);
            db.SaveChanges();

            Actor actor77 = new Actor();
            actor77.ActorName = "Natalie Wood";
            db.Actors.AddOrUpdate(g => g.ActorName, actor77);
            db.SaveChanges();

            Actor actor78 = new Actor();
            actor78.ActorName = "Richard Beymer";
            db.Actors.AddOrUpdate(g => g.ActorName, actor78);
            db.SaveChanges();

            Actor actor79 = new Actor();
            actor79.ActorName = "Russ Tamblyn";
            db.Actors.AddOrUpdate(g => g.ActorName, actor79);
            db.SaveChanges();

            Actor actor80 = new Actor();
            actor80.ActorName = "Rita Moreno";
            db.Actors.AddOrUpdate(g => g.ActorName, actor80);
            db.SaveChanges();

            Actor actor81 = new Actor();
            actor81.ActorName = "George Chakiris";
            db.Actors.AddOrUpdate(g => g.ActorName, actor81);
            db.SaveChanges();

            Actor actor82 = new Actor();
            actor82.ActorName = "Simon Oakland";
            db.Actors.AddOrUpdate(g => g.ActorName, actor82);
            db.SaveChanges();

            Actor actor83 = new Actor();
            actor83.ActorName = "John Wayne";
            db.Actors.AddOrUpdate(g => g.ActorName, actor83);
            db.SaveChanges();

            Actor actor84 = new Actor();
            actor84.ActorName = "Lee Marvin";
            db.Actors.AddOrUpdate(g => g.ActorName, actor84);
            db.SaveChanges();

            Actor actor85 = new Actor();
            actor85.ActorName = "Edmond O'Brien";
            db.Actors.AddOrUpdate(g => g.ActorName, actor85);
            db.SaveChanges();

            Actor actor86 = new Actor();
            actor86.ActorName = "Ken Murray";
            db.Actors.AddOrUpdate(g => g.ActorName, actor86);
            db.SaveChanges();

            Actor actor87 = new Actor();
            actor87.ActorName = "Sean Connery";
            db.Actors.AddOrUpdate(g => g.ActorName, actor87);
            db.SaveChanges();

            Actor actor88 = new Actor();
            actor88.ActorName = "Ursula Andress";
            db.Actors.AddOrUpdate(g => g.ActorName, actor88);
            db.SaveChanges();

            Actor actor89 = new Actor();
            actor89.ActorName = "Joseph Wiseman";
            db.Actors.AddOrUpdate(g => g.ActorName, actor89);
            db.SaveChanges();

            Actor actor90 = new Actor();
            actor90.ActorName = "Jack Lord";
            db.Actors.AddOrUpdate(g => g.ActorName, actor90);
            db.SaveChanges();

            Actor actor91 = new Actor();
            actor91.ActorName = "Bernard Lee";
            db.Actors.AddOrUpdate(g => g.ActorName, actor91);
            db.SaveChanges();

            Actor actor92 = new Actor();
            actor92.ActorName = "Anthony Dawson";
            db.Actors.AddOrUpdate(g => g.ActorName, actor92);
            db.SaveChanges();

            Actor actor93 = new Actor();
            actor93.ActorName = "Peter O'Toole";
            db.Actors.AddOrUpdate(g => g.ActorName, actor93);
            db.SaveChanges();

            Actor actor94 = new Actor();
            actor94.ActorName = "Alec Guinness";
            db.Actors.AddOrUpdate(g => g.ActorName, actor94);
            db.SaveChanges();

            Actor actor95 = new Actor();
            actor95.ActorName = "Anthony Quinn";
            db.Actors.AddOrUpdate(g => g.ActorName, actor95);
            db.SaveChanges();

            Actor actor96 = new Actor();
            actor96.ActorName = "Jack Hawkins";
            db.Actors.AddOrUpdate(g => g.ActorName, actor96);
            db.SaveChanges();

            Actor actor97 = new Actor();
            actor97.ActorName = "Omar Sharif";
            db.Actors.AddOrUpdate(g => g.ActorName, actor97);
            db.SaveChanges();

            Actor actor98 = new Actor();
            actor98.ActorName = "Claude Rains";
            db.Actors.AddOrUpdate(g => g.ActorName, actor98);
            db.SaveChanges();

            Actor actor99 = new Actor();
            actor99.ActorName = "Gregory Peck";
            db.Actors.AddOrUpdate(g => g.ActorName, actor99);
            db.SaveChanges();

            Actor actor100 = new Actor();
            actor100.ActorName = "Brock Peters";
            db.Actors.AddOrUpdate(g => g.ActorName, actor100);
            db.SaveChanges();

            Actor actor101 = new Actor();
            actor101.ActorName = "James Anderson";
            db.Actors.AddOrUpdate(g => g.ActorName, actor101);
            db.SaveChanges();

            Actor actor102 = new Actor();
            actor102.ActorName = "Mary Badham";
            db.Actors.AddOrUpdate(g => g.ActorName, actor102);
            db.SaveChanges();

            Actor actor103 = new Actor();
            actor103.ActorName = "Phillip Alford";
            db.Actors.AddOrUpdate(g => g.ActorName, actor103);
            db.SaveChanges();

            Actor actor104 = new Actor();
            actor104.ActorName = "John Megna";
            db.Actors.AddOrUpdate(g => g.ActorName, actor104);
            db.SaveChanges();

            Actor actor105 = new Actor();
            actor105.ActorName = "John Lennon";
            db.Actors.AddOrUpdate(g => g.ActorName, actor105);
            db.SaveChanges();

            Actor actor106 = new Actor();
            actor106.ActorName = "Paul McCartney";
            db.Actors.AddOrUpdate(g => g.ActorName, actor106);
            db.SaveChanges();

            Actor actor107 = new Actor();
            actor107.ActorName = "George Harrison";
            db.Actors.AddOrUpdate(g => g.ActorName, actor107);
            db.SaveChanges();

            Actor actor108 = new Actor();
            actor108.ActorName = "Ringo Starr";
            db.Actors.AddOrUpdate(g => g.ActorName, actor108);
            db.SaveChanges();

            Actor actor109 = new Actor();
            actor109.ActorName = "Wilfrid Brambell";
            db.Actors.AddOrUpdate(g => g.ActorName, actor109);
            db.SaveChanges();

            Actor actor110 = new Actor();
            actor110.ActorName = "Norman Rossington";
            db.Actors.AddOrUpdate(g => g.ActorName, actor110);
            db.SaveChanges();

            Actor actor111 = new Actor();
            actor111.ActorName = "Julie Andrews";
            db.Actors.AddOrUpdate(g => g.ActorName, actor111);
            db.SaveChanges();

            Actor actor112 = new Actor();
            actor112.ActorName = "Dick Van Dyke";
            db.Actors.AddOrUpdate(g => g.ActorName, actor112);
            db.SaveChanges();

            Actor actor113 = new Actor();
            actor113.ActorName = "David Tomlinson";
            db.Actors.AddOrUpdate(g => g.ActorName, actor113);
            db.SaveChanges();

            Actor actor114 = new Actor();
            actor114.ActorName = "Glynis Johns";
            db.Actors.AddOrUpdate(g => g.ActorName, actor114);
            db.SaveChanges();

            Actor actor115 = new Actor();
            actor115.ActorName = "Hermione Baddeley";
            db.Actors.AddOrUpdate(g => g.ActorName, actor115);
            db.SaveChanges();

            Actor actor116 = new Actor();
            actor116.ActorName = "Reta Shaw";
            db.Actors.AddOrUpdate(g => g.ActorName, actor116);
            db.SaveChanges();

            Actor actor117 = new Actor();
            actor117.ActorName = "Audrey Hepburn";
            db.Actors.AddOrUpdate(g => g.ActorName, actor117);
            db.SaveChanges();

            Actor actor118 = new Actor();
            actor118.ActorName = "Rex Harrison";
            db.Actors.AddOrUpdate(g => g.ActorName, actor118);
            db.SaveChanges();

            Actor actor119 = new Actor();
            actor119.ActorName = "Stanley Holloway";
            db.Actors.AddOrUpdate(g => g.ActorName, actor119);
            db.SaveChanges();

            Actor actor120 = new Actor();
            actor120.ActorName = "Wilfrid Hyde-White";
            db.Actors.AddOrUpdate(g => g.ActorName, actor120);
            db.SaveChanges();

            Actor actor121 = new Actor();
            actor121.ActorName = "Gladys Cooper";
            db.Actors.AddOrUpdate(g => g.ActorName, actor121);
            db.SaveChanges();

            Actor actor122 = new Actor();
            actor122.ActorName = "Jeremy Brett";
            db.Actors.AddOrUpdate(g => g.ActorName, actor122);
            db.SaveChanges();

            Actor actor123 = new Actor();
            actor123.ActorName = "Christopher Plummer";
            db.Actors.AddOrUpdate(g => g.ActorName, actor123);
            db.SaveChanges();

            Actor actor124 = new Actor();
            actor124.ActorName = "Eleanor Parker";
            db.Actors.AddOrUpdate(g => g.ActorName, actor124);
            db.SaveChanges();

            Actor actor125 = new Actor();
            actor125.ActorName = "Richard Haydn";
            db.Actors.AddOrUpdate(g => g.ActorName, actor125);
            db.SaveChanges();

            Actor actor126 = new Actor();
            actor126.ActorName = "Peggy Wood";
            db.Actors.AddOrUpdate(g => g.ActorName, actor126);
            db.SaveChanges();

            Actor actor127 = new Actor();
            actor127.ActorName = "Charmian Carr";
            db.Actors.AddOrUpdate(g => g.ActorName, actor127);
            db.SaveChanges();

            Actor actor128 = new Actor();
            actor128.ActorName = "Robert Redford";
            db.Actors.AddOrUpdate(g => g.ActorName, actor128);
            db.SaveChanges();

            Actor actor129 = new Actor();
            actor129.ActorName = "Katharine Ross";
            db.Actors.AddOrUpdate(g => g.ActorName, actor129);
            db.SaveChanges();

            Actor actor130 = new Actor();
            actor130.ActorName = "Strother Martin";
            db.Actors.AddOrUpdate(g => g.ActorName, actor130);
            db.SaveChanges();

            Actor actor131 = new Actor();
            actor131.ActorName = "Henry Jones";
            db.Actors.AddOrUpdate(g => g.ActorName, actor131);
            db.SaveChanges();

            Actor actor132 = new Actor();
            actor132.ActorName = "Jeff Corey";
            db.Actors.AddOrUpdate(g => g.ActorName, actor132);
            db.SaveChanges();

            Actor actor133 = new Actor();
            actor133.ActorName = "Richard Benjamin";
            db.Actors.AddOrUpdate(g => g.ActorName, actor133);
            db.SaveChanges();

            Actor actor134 = new Actor();
            actor134.ActorName = "Art Garfunkel";
            db.Actors.AddOrUpdate(g => g.ActorName, actor134);
            db.SaveChanges();

            Actor actor135 = new Actor();
            actor135.ActorName = "Jack Gilford";
            db.Actors.AddOrUpdate(g => g.ActorName, actor135);
            db.SaveChanges();

            Actor actor136 = new Actor();
            actor136.ActorName = "Buck Henry";
            db.Actors.AddOrUpdate(g => g.ActorName, actor136);
            db.SaveChanges();

            Actor actor137 = new Actor();
            actor137.ActorName = "Bob Newhart";
            db.Actors.AddOrUpdate(g => g.ActorName, actor137);
            db.SaveChanges();

            Actor actor138 = new Actor();
            actor138.ActorName = "Gene Wilder";
            db.Actors.AddOrUpdate(g => g.ActorName, actor138);
            db.SaveChanges();

            Actor actor139 = new Actor();
            actor139.ActorName = "Jack Albertson";
            db.Actors.AddOrUpdate(g => g.ActorName, actor139);
            db.SaveChanges();

            Actor actor140 = new Actor();
            actor140.ActorName = "Peter Ostrum";
            db.Actors.AddOrUpdate(g => g.ActorName, actor140);
            db.SaveChanges();

            Actor actor141 = new Actor();
            actor141.ActorName = "Roy Kinnear";
            db.Actors.AddOrUpdate(g => g.ActorName, actor141);
            db.SaveChanges();

            Actor actor142 = new Actor();
            actor142.ActorName = "Denise Nickerson";
            db.Actors.AddOrUpdate(g => g.ActorName, actor142);
            db.SaveChanges();

            Actor actor143 = new Actor();
            actor143.ActorName = "Leonard Stone";
            db.Actors.AddOrUpdate(g => g.ActorName, actor143);
            db.SaveChanges();

            Actor actor144 = new Actor();
            actor144.ActorName = "Chaim Topol";
            db.Actors.AddOrUpdate(g => g.ActorName, actor144);
            db.SaveChanges();

            Actor actor145 = new Actor();
            actor145.ActorName = "Norma Crane";
            db.Actors.AddOrUpdate(g => g.ActorName, actor145);
            db.SaveChanges();

            Actor actor146 = new Actor();
            actor146.ActorName = "Leonard Frey";
            db.Actors.AddOrUpdate(g => g.ActorName, actor146);
            db.SaveChanges();

            Actor actor147 = new Actor();
            actor147.ActorName = "Molly Picon";
            db.Actors.AddOrUpdate(g => g.ActorName, actor147);
            db.SaveChanges();

            Actor actor148 = new Actor();
            actor148.ActorName = "Paul Mann";
            db.Actors.AddOrUpdate(g => g.ActorName, actor148);
            db.SaveChanges();

            Actor actor149 = new Actor();
            actor149.ActorName = "Rosalind Harris";
            db.Actors.AddOrUpdate(g => g.ActorName, actor149);
            db.SaveChanges();

            Actor actor150 = new Actor();
            actor150.ActorName = "Jill St. John";
            db.Actors.AddOrUpdate(g => g.ActorName, actor150);
            db.SaveChanges();

            Actor actor151 = new Actor();
            actor151.ActorName = "Charles Gray";
            db.Actors.AddOrUpdate(g => g.ActorName, actor151);
            db.SaveChanges();

            Actor actor152 = new Actor();
            actor152.ActorName = "Lana Wood";
            db.Actors.AddOrUpdate(g => g.ActorName, actor152);
            db.SaveChanges();

            Actor actor153 = new Actor();
            actor153.ActorName = "Jimmy Dean";
            db.Actors.AddOrUpdate(g => g.ActorName, actor153);
            db.SaveChanges();

            Actor actor154 = new Actor();
            actor154.ActorName = "Bruce Cabot";
            db.Actors.AddOrUpdate(g => g.ActorName, actor154);
            db.SaveChanges();

            Actor actor155 = new Actor();
            actor155.ActorName = "Richard Dreyfuss";
            db.Actors.AddOrUpdate(g => g.ActorName, actor155);
            db.SaveChanges();

            Actor actor156 = new Actor();
            actor156.ActorName = "Ron Howard";
            db.Actors.AddOrUpdate(g => g.ActorName, actor156);
            db.SaveChanges();

            Actor actor157 = new Actor();
            actor157.ActorName = "Paul Le Mat";
            db.Actors.AddOrUpdate(g => g.ActorName, actor157);
            db.SaveChanges();

            Actor actor158 = new Actor();
            actor158.ActorName = "Charles Martin Smith";
            db.Actors.AddOrUpdate(g => g.ActorName, actor158);
            db.SaveChanges();

            Actor actor159 = new Actor();
            actor159.ActorName = "Cindy Williams";
            db.Actors.AddOrUpdate(g => g.ActorName, actor159);
            db.SaveChanges();

            Actor actor160 = new Actor();
            actor160.ActorName = "Candy Clark";
            db.Actors.AddOrUpdate(g => g.ActorName, actor160);
            db.SaveChanges();

            Actor actor161 = new Actor();
            actor161.ActorName = "Robert Shaw";
            db.Actors.AddOrUpdate(g => g.ActorName, actor161);
            db.SaveChanges();

            Actor actor162 = new Actor();
            actor162.ActorName = "Charles Durning";
            db.Actors.AddOrUpdate(g => g.ActorName, actor162);
            db.SaveChanges();

            Actor actor163 = new Actor();
            actor163.ActorName = "Ray Walston";
            db.Actors.AddOrUpdate(g => g.ActorName, actor163);
            db.SaveChanges();

            Actor actor164 = new Actor();
            actor164.ActorName = "Eileen Brennan";
            db.Actors.AddOrUpdate(g => g.ActorName, actor164);
            db.SaveChanges();

            Actor actor165 = new Actor();
            actor165.ActorName = "Linda Blair";
            db.Actors.AddOrUpdate(g => g.ActorName, actor165);
            db.SaveChanges();

            Actor actor166 = new Actor();
            actor166.ActorName = "Max von Sydow";
            db.Actors.AddOrUpdate(g => g.ActorName, actor166);
            db.SaveChanges();

            Actor actor167 = new Actor();
            actor167.ActorName = "Ellen Burstyn";
            db.Actors.AddOrUpdate(g => g.ActorName, actor167);
            db.SaveChanges();

            Actor actor168 = new Actor();
            actor168.ActorName = "Jason Miller";
            db.Actors.AddOrUpdate(g => g.ActorName, actor168);
            db.SaveChanges();

            Actor actor169 = new Actor();
            actor169.ActorName = "Lee J. Cobb";
            db.Actors.AddOrUpdate(g => g.ActorName, actor169);
            db.SaveChanges();

            Actor actor170 = new Actor();
            actor170.ActorName = "Kitty Winn";
            db.Actors.AddOrUpdate(g => g.ActorName, actor170);
            db.SaveChanges();

            Actor actor171 = new Actor();
            actor171.ActorName = "Cleavon Little";
            db.Actors.AddOrUpdate(g => g.ActorName, actor171);
            db.SaveChanges();

            Actor actor172 = new Actor();
            actor172.ActorName = "Harvey Korman";
            db.Actors.AddOrUpdate(g => g.ActorName, actor172);
            db.SaveChanges();

            Actor actor173 = new Actor();
            actor173.ActorName = "Slim Pickens";
            db.Actors.AddOrUpdate(g => g.ActorName, actor173);
            db.SaveChanges();

            Actor actor174 = new Actor();
            actor174.ActorName = "Madeline Kahn";
            db.Actors.AddOrUpdate(g => g.ActorName, actor174);
            db.SaveChanges();

            Actor actor175 = new Actor();
            actor175.ActorName = "Mel Brooks";
            db.Actors.AddOrUpdate(g => g.ActorName, actor175);
            db.SaveChanges();

            Actor actor176 = new Actor();
            actor176.ActorName = "Graham Chapman";
            db.Actors.AddOrUpdate(g => g.ActorName, actor176);
            db.SaveChanges();

            Actor actor177 = new Actor();
            actor177.ActorName = "John Cleese";
            db.Actors.AddOrUpdate(g => g.ActorName, actor177);
            db.SaveChanges();

            Actor actor178 = new Actor();
            actor178.ActorName = "Terry Gilliam";
            db.Actors.AddOrUpdate(g => g.ActorName, actor178);
            db.SaveChanges();

            Actor actor179 = new Actor();
            actor179.ActorName = "Eric Idle";
            db.Actors.AddOrUpdate(g => g.ActorName, actor179);
            db.SaveChanges();

            Actor actor180 = new Actor();
            actor180.ActorName = "Terry Jones";
            db.Actors.AddOrUpdate(g => g.ActorName, actor180);
            db.SaveChanges();

            Actor actor181 = new Actor();
            actor181.ActorName = "Michael Palin";
            db.Actors.AddOrUpdate(g => g.ActorName, actor181);
            db.SaveChanges();

            Actor actor182 = new Actor();
            actor182.ActorName = "Roy Scheider";
            db.Actors.AddOrUpdate(g => g.ActorName, actor182);
            db.SaveChanges();

            Actor actor183 = new Actor();
            actor183.ActorName = "Lorraine Gary";
            db.Actors.AddOrUpdate(g => g.ActorName, actor183);
            db.SaveChanges();

            Actor actor184 = new Actor();
            actor184.ActorName = "Murray Hamilton";
            db.Actors.AddOrUpdate(g => g.ActorName, actor184);
            db.SaveChanges();

            Actor actor185 = new Actor();
            actor185.ActorName = "Carl Gottlieb";
            db.Actors.AddOrUpdate(g => g.ActorName, actor185);
            db.SaveChanges();

            Actor actor186 = new Actor();
            actor186.ActorName = "Mark Hamill";
            db.Actors.AddOrUpdate(g => g.ActorName, actor186);
            db.SaveChanges();

            Actor actor187 = new Actor();
            actor187.ActorName = "Harrison Ford";
            db.Actors.AddOrUpdate(g => g.ActorName, actor187);
            db.SaveChanges();

            Actor actor188 = new Actor();
            actor188.ActorName = "Carrie Fisher";
            db.Actors.AddOrUpdate(g => g.ActorName, actor188);
            db.SaveChanges();

            Actor actor189 = new Actor();
            actor189.ActorName = "Peter Cushing";
            db.Actors.AddOrUpdate(g => g.ActorName, actor189);
            db.SaveChanges();

            Actor actor190 = new Actor();
            actor190.ActorName = "Anthony Daniels";
            db.Actors.AddOrUpdate(g => g.ActorName, actor190);
            db.SaveChanges();

            Actor actor191 = new Actor();
            actor191.ActorName = "Roger Moore";
            db.Actors.AddOrUpdate(g => g.ActorName, actor191);
            db.SaveChanges();

            Actor actor192 = new Actor();
            actor192.ActorName = "Barbara Bach";
            db.Actors.AddOrUpdate(g => g.ActorName, actor192);
            db.SaveChanges();

            Actor actor193 = new Actor();
            actor193.ActorName = "Curd Joergens";
            db.Actors.AddOrUpdate(g => g.ActorName, actor193);
            db.SaveChanges();

            Actor actor194 = new Actor();
            actor194.ActorName = "Richard Kiel";
            db.Actors.AddOrUpdate(g => g.ActorName, actor194);
            db.SaveChanges();

            Actor actor195 = new Actor();
            actor195.ActorName = "Caroline Munro";
            db.Actors.AddOrUpdate(g => g.ActorName, actor195);
            db.SaveChanges();

            Actor actor196 = new Actor();
            actor196.ActorName = "Walter Gotell";
            db.Actors.AddOrUpdate(g => g.ActorName, actor196);
            db.SaveChanges();

            Actor actor197 = new Actor();
            actor197.ActorName = "Francois Truffaut";
            db.Actors.AddOrUpdate(g => g.ActorName, actor197);
            db.SaveChanges();

            Actor actor198 = new Actor();
            actor198.ActorName = "Teri Garr";
            db.Actors.AddOrUpdate(g => g.ActorName, actor198);
            db.SaveChanges();

            Actor actor199 = new Actor();
            actor199.ActorName = "Melinda Dillon";
            db.Actors.AddOrUpdate(g => g.ActorName, actor199);
            db.SaveChanges();

            Actor actor200 = new Actor();
            actor200.ActorName = "Bob Balaban";
            db.Actors.AddOrUpdate(g => g.ActorName, actor200);
            db.SaveChanges();

            Actor actor201 = new Actor();
            actor201.ActorName = "J. Patrick McNamara";
            db.Actors.AddOrUpdate(g => g.ActorName, actor201);
            db.SaveChanges();

            Actor actor202 = new Actor();
            actor202.ActorName = "John Travolta";
            db.Actors.AddOrUpdate(g => g.ActorName, actor202);
            db.SaveChanges();

            Actor actor203 = new Actor();
            actor203.ActorName = "Olivia Newton-John";
            db.Actors.AddOrUpdate(g => g.ActorName, actor203);
            db.SaveChanges();

            Actor actor204 = new Actor();
            actor204.ActorName = "Stockard Channing";
            db.Actors.AddOrUpdate(g => g.ActorName, actor204);
            db.SaveChanges();

            Actor actor205 = new Actor();
            actor205.ActorName = "Jeff Conaway";
            db.Actors.AddOrUpdate(g => g.ActorName, actor205);
            db.SaveChanges();

            Actor actor206 = new Actor();
            actor206.ActorName = "Didi Conn";
            db.Actors.AddOrUpdate(g => g.ActorName, actor206);
            db.SaveChanges();

            Actor actor207 = new Actor();
            actor207.ActorName = "Barry Pearl";
            db.Actors.AddOrUpdate(g => g.ActorName, actor207);
            db.SaveChanges();

            Actor actor208 = new Actor();
            actor208.ActorName = "John Belushi";
            db.Actors.AddOrUpdate(g => g.ActorName, actor208);
            db.SaveChanges();

            Actor actor209 = new Actor();
            actor209.ActorName = "Tim Matheson";
            db.Actors.AddOrUpdate(g => g.ActorName, actor209);
            db.SaveChanges();

            Actor actor210 = new Actor();
            actor210.ActorName = "John Vernon";
            db.Actors.AddOrUpdate(g => g.ActorName, actor210);
            db.SaveChanges();

            Actor actor211 = new Actor();
            actor211.ActorName = "Verna Bloom";
            db.Actors.AddOrUpdate(g => g.ActorName, actor211);
            db.SaveChanges();

            Actor actor212 = new Actor();
            actor212.ActorName = "Tom Hulce";
            db.Actors.AddOrUpdate(g => g.ActorName, actor212);
            db.SaveChanges();

            Actor actor213 = new Actor();
            actor213.ActorName = "Cesare Danova";
            db.Actors.AddOrUpdate(g => g.ActorName, actor213);
            db.SaveChanges();

            Actor actor214 = new Actor();
            actor214.ActorName = "Donald Pleasence";
            db.Actors.AddOrUpdate(g => g.ActorName, actor214);
            db.SaveChanges();

            Actor actor215 = new Actor();
            actor215.ActorName = "Jamie Lee Curtis";
            db.Actors.AddOrUpdate(g => g.ActorName, actor215);
            db.SaveChanges();

            Actor actor216 = new Actor();
            actor216.ActorName = "P.J. Soles";
            db.Actors.AddOrUpdate(g => g.ActorName, actor216);
            db.SaveChanges();

            Actor actor217 = new Actor();
            actor217.ActorName = "Nancy Kyes";
            db.Actors.AddOrUpdate(g => g.ActorName, actor217);
            db.SaveChanges();

            Actor actor218 = new Actor();
            actor218.ActorName = "Nick Castle";
            db.Actors.AddOrUpdate(g => g.ActorName, actor218);
            db.SaveChanges();

            Actor actor219 = new Actor();
            actor219.ActorName = "Tony Moran";
            db.Actors.AddOrUpdate(g => g.ActorName, actor219);
            db.SaveChanges();

            Actor actor220 = new Actor();
            actor220.ActorName = "Tom Skerritt";
            db.Actors.AddOrUpdate(g => g.ActorName, actor220);
            db.SaveChanges();

            Actor actor221 = new Actor();
            actor221.ActorName = "Sigourney Weaver";
            db.Actors.AddOrUpdate(g => g.ActorName, actor221);
            db.SaveChanges();

            Actor actor222 = new Actor();
            actor222.ActorName = "Veronica Cartwright";
            db.Actors.AddOrUpdate(g => g.ActorName, actor222);
            db.SaveChanges();

            Actor actor223 = new Actor();
            actor223.ActorName = "Harry Dean Stanton";
            db.Actors.AddOrUpdate(g => g.ActorName, actor223);
            db.SaveChanges();

            Actor actor224 = new Actor();
            actor224.ActorName = "John Hurt";
            db.Actors.AddOrUpdate(g => g.ActorName, actor224);
            db.SaveChanges();

            Actor actor225 = new Actor();
            actor225.ActorName = "Ian Holm";
            db.Actors.AddOrUpdate(g => g.ActorName, actor225);
            db.SaveChanges();

            Actor actor226 = new Actor();
            actor226.ActorName = "Jim Henson";
            db.Actors.AddOrUpdate(g => g.ActorName, actor226);
            db.SaveChanges();

            Actor actor227 = new Actor();
            actor227.ActorName = "Frank Oz";
            db.Actors.AddOrUpdate(g => g.ActorName, actor227);
            db.SaveChanges();

            Actor actor228 = new Actor();
            actor228.ActorName = "Jerry Nelson";
            db.Actors.AddOrUpdate(g => g.ActorName, actor228);
            db.SaveChanges();

            Actor actor229 = new Actor();
            actor229.ActorName = "Richard Hunt";
            db.Actors.AddOrUpdate(g => g.ActorName, actor229);
            db.SaveChanges();

            Actor actor230 = new Actor();
            actor230.ActorName = "Dave Goelz";
            db.Actors.AddOrUpdate(g => g.ActorName, actor230);
            db.SaveChanges();

            Actor actor231 = new Actor();
            actor231.ActorName = "Charles Durning";
            db.Actors.AddOrUpdate(g => g.ActorName, actor231);
            db.SaveChanges();

            Actor actor232 = new Actor();
            actor232.ActorName = "Martin Sheen";
            db.Actors.AddOrUpdate(g => g.ActorName, actor232);
            db.SaveChanges();

            Actor actor233 = new Actor();
            actor233.ActorName = "Robert Duvall";
            db.Actors.AddOrUpdate(g => g.ActorName, actor233);
            db.SaveChanges();

            Actor actor234 = new Actor();
            actor234.ActorName = "Frederic Forrest";
            db.Actors.AddOrUpdate(g => g.ActorName, actor234);
            db.SaveChanges();

            Actor actor235 = new Actor();
            actor235.ActorName = "Sam Bottoms";
            db.Actors.AddOrUpdate(g => g.ActorName, actor235);
            db.SaveChanges();

            Actor actor236 = new Actor();
            actor236.ActorName = "Laurence Fishburne";
            db.Actors.AddOrUpdate(g => g.ActorName, actor236);
            db.SaveChanges();

            Actor actor237 = new Actor();
            actor237.ActorName = "Billy Dee Williams";
            db.Actors.AddOrUpdate(g => g.ActorName, actor237);
            db.SaveChanges();

            Actor actor238 = new Actor();
            actor238.ActorName = "David Prowse";
            db.Actors.AddOrUpdate(g => g.ActorName, actor238);
            db.SaveChanges();

            Actor actor239 = new Actor();
            actor239.ActorName = "Jack Nicholson";
            db.Actors.AddOrUpdate(g => g.ActorName, actor239);
            db.SaveChanges();

            Actor actor240 = new Actor();
            actor240.ActorName = "Shelley Duvall";
            db.Actors.AddOrUpdate(g => g.ActorName, actor240);
            db.SaveChanges();

            Actor actor241 = new Actor();
            actor241.ActorName = "Danny Lloyd";
            db.Actors.AddOrUpdate(g => g.ActorName, actor241);
            db.SaveChanges();

            Actor actor242 = new Actor();
            actor242.ActorName = "Scatman Crothers";
            db.Actors.AddOrUpdate(g => g.ActorName, actor242);
            db.SaveChanges();

            Actor actor243 = new Actor();
            actor243.ActorName = "Barry Nelson";
            db.Actors.AddOrUpdate(g => g.ActorName, actor243);
            db.SaveChanges();

            Actor actor244 = new Actor();
            actor244.ActorName = "Philip Stone";
            db.Actors.AddOrUpdate(g => g.ActorName, actor244);
            db.SaveChanges();

            Actor actor245 = new Actor();
            actor245.ActorName = "Robert Hays";
            db.Actors.AddOrUpdate(g => g.ActorName, actor245);
            db.SaveChanges();

            Actor actor246 = new Actor();
            actor246.ActorName = "Julie Hagerty";
            db.Actors.AddOrUpdate(g => g.ActorName, actor246);
            db.SaveChanges();

            Actor actor247 = new Actor();
            actor247.ActorName = "Kareem Abdul-Jabbar";
            db.Actors.AddOrUpdate(g => g.ActorName, actor247);
            db.SaveChanges();

            Actor actor248 = new Actor();
            actor248.ActorName = "Lloyd Bridges";
            db.Actors.AddOrUpdate(g => g.ActorName, actor248);
            db.SaveChanges();

            Actor actor249 = new Actor();
            actor249.ActorName = "Peter Graves";
            db.Actors.AddOrUpdate(g => g.ActorName, actor249);
            db.SaveChanges();

            Actor actor250 = new Actor();
            actor250.ActorName = "Leslie Nielsen";
            db.Actors.AddOrUpdate(g => g.ActorName, actor250);
            db.SaveChanges();

            Actor actor251 = new Actor();
            actor251.ActorName = "Chevy Chase";
            db.Actors.AddOrUpdate(g => g.ActorName, actor251);
            db.SaveChanges();

            Actor actor252 = new Actor();
            actor252.ActorName = "Rodney Dangerfield";
            db.Actors.AddOrUpdate(g => g.ActorName, actor252);
            db.SaveChanges();

            Actor actor253 = new Actor();
            actor253.ActorName = "Ted Knight";
            db.Actors.AddOrUpdate(g => g.ActorName, actor253);
            db.SaveChanges();

            Actor actor254 = new Actor();
            actor254.ActorName = "Michael O'Keefe";
            db.Actors.AddOrUpdate(g => g.ActorName, actor254);
            db.SaveChanges();

            Actor actor255 = new Actor();
            actor255.ActorName = "Bill Murray";
            db.Actors.AddOrUpdate(g => g.ActorName, actor255);
            db.SaveChanges();

            Actor actor256 = new Actor();
            actor256.ActorName = "Sarah Holcomb";
            db.Actors.AddOrUpdate(g => g.ActorName, actor256);
            db.SaveChanges();

            Actor actor257 = new Actor();
            actor257.ActorName = "Robert De Niro";
            db.Actors.AddOrUpdate(g => g.ActorName, actor257);
            db.SaveChanges();

            Actor actor258 = new Actor();
            actor258.ActorName = "Joe Pesci";
            db.Actors.AddOrUpdate(g => g.ActorName, actor258);
            db.SaveChanges();

            Actor actor259 = new Actor();
            actor259.ActorName = "Cathy Moriarty";
            db.Actors.AddOrUpdate(g => g.ActorName, actor259);
            db.SaveChanges();

            Actor actor260 = new Actor();
            actor260.ActorName = "Frank Vincent";
            db.Actors.AddOrUpdate(g => g.ActorName, actor260);
            db.SaveChanges();

            Actor actor261 = new Actor();
            actor261.ActorName = "Nicholas Colasanto";
            db.Actors.AddOrUpdate(g => g.ActorName, actor261);
            db.SaveChanges();

            Actor actor262 = new Actor();
            actor262.ActorName = "Theresa Saldana";
            db.Actors.AddOrUpdate(g => g.ActorName, actor262);
            db.SaveChanges();

            Actor actor263 = new Actor();
            actor263.ActorName = "Karen Allen";
            db.Actors.AddOrUpdate(g => g.ActorName, actor263);
            db.SaveChanges();

            Actor actor264 = new Actor();
            actor264.ActorName = "Paul Freeman";
            db.Actors.AddOrUpdate(g => g.ActorName, actor264);
            db.SaveChanges();

            Actor actor265 = new Actor();
            actor265.ActorName = "Ronald Lacey";
            db.Actors.AddOrUpdate(g => g.ActorName, actor265);
            db.SaveChanges();

            Actor actor266 = new Actor();
            actor266.ActorName = "John Rhys-Davies";
            db.Actors.AddOrUpdate(g => g.ActorName, actor266);
            db.SaveChanges();

            Actor actor267 = new Actor();
            actor267.ActorName = "Denholm Elliott";
            db.Actors.AddOrUpdate(g => g.ActorName, actor267);
            db.SaveChanges();

            Actor actor268 = new Actor();
            actor268.ActorName = "Henry Thomas";
            db.Actors.AddOrUpdate(g => g.ActorName, actor268);
            db.SaveChanges();

            Actor actor269 = new Actor();
            actor269.ActorName = "Drew Barrymore";
            db.Actors.AddOrUpdate(g => g.ActorName, actor269);
            db.SaveChanges();

            Actor actor270 = new Actor();
            actor270.ActorName = "Robert MacNaughton";
            db.Actors.AddOrUpdate(g => g.ActorName, actor270);
            db.SaveChanges();

            Actor actor271 = new Actor();
            actor271.ActorName = "Dee Wallace";
            db.Actors.AddOrUpdate(g => g.ActorName, actor271);
            db.SaveChanges();

            Actor actor272 = new Actor();
            actor272.ActorName = "Peter Coyote";
            db.Actors.AddOrUpdate(g => g.ActorName, actor272);
            db.SaveChanges();

            Actor actor273 = new Actor();
            actor273.ActorName = "Erika Eleniak";
            db.Actors.AddOrUpdate(g => g.ActorName, actor273);
            db.SaveChanges();

            Actor actor274 = new Actor();
            actor274.ActorName = "Sean Penn";
            db.Actors.AddOrUpdate(g => g.ActorName, actor274);
            db.SaveChanges();

            Actor actor275 = new Actor();
            actor275.ActorName = "Jennifer Jason Leigh";
            db.Actors.AddOrUpdate(g => g.ActorName, actor275);
            db.SaveChanges();

            Actor actor276 = new Actor();
            actor276.ActorName = "Judge Reinhold";
            db.Actors.AddOrUpdate(g => g.ActorName, actor276);
            db.SaveChanges();

            Actor actor277 = new Actor();
            actor277.ActorName = "Phoebe Cates";
            db.Actors.AddOrUpdate(g => g.ActorName, actor277);
            db.SaveChanges();

            Actor actor278 = new Actor();
            actor278.ActorName = "Brian Backer";
            db.Actors.AddOrUpdate(g => g.ActorName, actor278);
            db.SaveChanges();

            Actor actor279 = new Actor();
            actor279.ActorName = "Robert Romanus";
            db.Actors.AddOrUpdate(g => g.ActorName, actor279);
            db.SaveChanges();

            Actor actor280 = new Actor();
            actor280.ActorName = "David Prowse";
            db.Actors.AddOrUpdate(g => g.ActorName, actor280);
            db.SaveChanges();

            Actor actor281 = new Actor();
            actor281.ActorName = "Matthew Broderick";
            db.Actors.AddOrUpdate(g => g.ActorName, actor281);
            db.SaveChanges();

            Actor actor282 = new Actor();
            actor282.ActorName = "Dabney Coleman";
            db.Actors.AddOrUpdate(g => g.ActorName, actor282);
            db.SaveChanges();

            Actor actor283 = new Actor();
            actor283.ActorName = "Ally Sheedy";
            db.Actors.AddOrUpdate(g => g.ActorName, actor283);
            db.SaveChanges();

            Actor actor284 = new Actor();
            actor284.ActorName = "John Wood";
            db.Actors.AddOrUpdate(g => g.ActorName, actor284);
            db.SaveChanges();

            Actor actor285 = new Actor();
            actor285.ActorName = "Barry Corbin";
            db.Actors.AddOrUpdate(g => g.ActorName, actor285);
            db.SaveChanges();

            Actor actor286 = new Actor();
            actor286.ActorName = "Juanin Clay";
            db.Actors.AddOrUpdate(g => g.ActorName, actor286);
            db.SaveChanges();

            Actor actor287 = new Actor();
            actor287.ActorName = "Eddie Murphy";
            db.Actors.AddOrUpdate(g => g.ActorName, actor287);
            db.SaveChanges();

            Actor actor288 = new Actor();
            actor288.ActorName = "Dan Aykroyd";
            db.Actors.AddOrUpdate(g => g.ActorName, actor288);
            db.SaveChanges();

            Actor actor289 = new Actor();
            actor289.ActorName = "Jim Belushi";
            db.Actors.AddOrUpdate(g => g.ActorName, actor289);
            db.SaveChanges();

            Actor actor290 = new Actor();
            actor290.ActorName = "Ralph Bellamy";
            db.Actors.AddOrUpdate(g => g.ActorName, actor290);
            db.SaveChanges();

            Actor actor291 = new Actor();
            actor291.ActorName = "Darren McGavin";
            db.Actors.AddOrUpdate(g => g.ActorName, actor291);
            db.SaveChanges();

            Actor actor292 = new Actor();
            actor292.ActorName = "Peter Billingsley";
            db.Actors.AddOrUpdate(g => g.ActorName, actor292);
            db.SaveChanges();

            Actor actor293 = new Actor();
            actor293.ActorName = "Jean Shepherd";
            db.Actors.AddOrUpdate(g => g.ActorName, actor293);
            db.SaveChanges();

            Actor actor294 = new Actor();
            actor294.ActorName = "Ian Petrella";
            db.Actors.AddOrUpdate(g => g.ActorName, actor294);
            db.SaveChanges();

            Actor actor295 = new Actor();
            actor295.ActorName = "Scott Schwartz";
            db.Actors.AddOrUpdate(g => g.ActorName, actor295);
            db.SaveChanges();

            Actor actor296 = new Actor();
            actor296.ActorName = "Kevin Bacon";
            db.Actors.AddOrUpdate(g => g.ActorName, actor296);
            db.SaveChanges();

            Actor actor297 = new Actor();
            actor297.ActorName = "John Lithgow";
            db.Actors.AddOrUpdate(g => g.ActorName, actor297);
            db.SaveChanges();

            Actor actor298 = new Actor();
            actor298.ActorName = "Dianne Wiest";
            db.Actors.AddOrUpdate(g => g.ActorName, actor298);
            db.SaveChanges();

            Actor actor299 = new Actor();
            actor299.ActorName = "Chris Penn";
            db.Actors.AddOrUpdate(g => g.ActorName, actor299);
            db.SaveChanges();

            Actor actor300 = new Actor();
            actor300.ActorName = "Lori Singer";
            db.Actors.AddOrUpdate(g => g.ActorName, actor300);
            db.SaveChanges();

            Actor actor301 = new Actor();
            actor301.ActorName = "Sarah Jessica Parker";
            db.Actors.AddOrUpdate(g => g.ActorName, actor301);
            db.SaveChanges();

            Actor actor302 = new Actor();
            actor302.ActorName = "Michael J. Fox";
            db.Actors.AddOrUpdate(g => g.ActorName, actor302);
            db.SaveChanges();

            Actor actor303 = new Actor();
            actor303.ActorName = "Christopher Lloyd";
            db.Actors.AddOrUpdate(g => g.ActorName, actor303);
            db.SaveChanges();

            Actor actor304 = new Actor();
            actor304.ActorName = "Lea Thompson";
            db.Actors.AddOrUpdate(g => g.ActorName, actor304);
            db.SaveChanges();

            Actor actor305 = new Actor();
            actor305.ActorName = "Crispin Glover";
            db.Actors.AddOrUpdate(g => g.ActorName, actor305);
            db.SaveChanges();

            Actor actor306 = new Actor();
            actor306.ActorName = "Thomas F. Wilson";
            db.Actors.AddOrUpdate(g => g.ActorName, actor306);
            db.SaveChanges();

            Actor actor307 = new Actor();
            actor307.ActorName = "Claudia Wells";
            db.Actors.AddOrUpdate(g => g.ActorName, actor307);
            db.SaveChanges();

            Actor actor308 = new Actor();
            actor308.ActorName = "Whoopi Goldberg";
            db.Actors.AddOrUpdate(g => g.ActorName, actor308);
            db.SaveChanges();

            Actor actor309 = new Actor();
            actor309.ActorName = "Margaret Avery";
            db.Actors.AddOrUpdate(g => g.ActorName, actor309);
            db.SaveChanges();

            Actor actor310 = new Actor();
            actor310.ActorName = "Danny Glover";
            db.Actors.AddOrUpdate(g => g.ActorName, actor310);
            db.SaveChanges();

            Actor actor311 = new Actor();
            actor311.ActorName = "Akosua Busia";
            db.Actors.AddOrUpdate(g => g.ActorName, actor311);
            db.SaveChanges();

            Actor actor312 = new Actor();
            actor312.ActorName = "Oprah Winfrey";
            db.Actors.AddOrUpdate(g => g.ActorName, actor312);
            db.SaveChanges();

            Actor actor313 = new Actor();
            actor313.ActorName = "Willard E. Pugh";
            db.Actors.AddOrUpdate(g => g.ActorName, actor313);
            db.SaveChanges();

            Actor actor314 = new Actor();
            actor314.ActorName = "Tom Cruise";
            db.Actors.AddOrUpdate(g => g.ActorName, actor314);
            db.SaveChanges();

            Actor actor315 = new Actor();
            actor315.ActorName = "Kelly McGillis";
            db.Actors.AddOrUpdate(g => g.ActorName, actor315);
            db.SaveChanges();

            Actor actor316 = new Actor();
            actor316.ActorName = "Val Kilmer";
            db.Actors.AddOrUpdate(g => g.ActorName, actor316);
            db.SaveChanges();

            Actor actor317 = new Actor();
            actor317.ActorName = "Anthony Edwards";
            db.Actors.AddOrUpdate(g => g.ActorName, actor317);
            db.SaveChanges();

            Actor actor318 = new Actor();
            actor318.ActorName = "Michael Ironside";
            db.Actors.AddOrUpdate(g => g.ActorName, actor318);
            db.SaveChanges();

            Actor actor319 = new Actor();
            actor319.ActorName = "Rick Moranis";
            db.Actors.AddOrUpdate(g => g.ActorName, actor319);
            db.SaveChanges();

            Actor actor320 = new Actor();
            actor320.ActorName = "Ellen Greene";
            db.Actors.AddOrUpdate(g => g.ActorName, actor320);
            db.SaveChanges();

            Actor actor321 = new Actor();
            actor321.ActorName = "Vincent Gardenia";
            db.Actors.AddOrUpdate(g => g.ActorName, actor321);
            db.SaveChanges();

            Actor actor322 = new Actor();
            actor322.ActorName = "Steve Martin";
            db.Actors.AddOrUpdate(g => g.ActorName, actor322);
            db.SaveChanges();

            Actor actor323 = new Actor();
            actor323.ActorName = "Tisha Campbell-Martin";
            db.Actors.AddOrUpdate(g => g.ActorName, actor323);
            db.SaveChanges();

            Actor actor324 = new Actor();
            actor324.ActorName = "John Candy";
            db.Actors.AddOrUpdate(g => g.ActorName, actor324);
            db.SaveChanges();

            Actor actor325 = new Actor();
            actor325.ActorName = "Bill Pullman";
            db.Actors.AddOrUpdate(g => g.ActorName, actor325);
            db.SaveChanges();

            Actor actor326 = new Actor();
            actor326.ActorName = "Daphne Zuniga";
            db.Actors.AddOrUpdate(g => g.ActorName, actor326);
            db.SaveChanges();

            Actor actor327 = new Actor();
            actor327.ActorName = "George Wyner";
            db.Actors.AddOrUpdate(g => g.ActorName, actor327);
            db.SaveChanges();

            Actor actor328 = new Actor();
            actor328.ActorName = "Cary Elwes";
            db.Actors.AddOrUpdate(g => g.ActorName, actor328);
            db.SaveChanges();

            Actor actor329 = new Actor();
            actor329.ActorName = "Robin Wright";
            db.Actors.AddOrUpdate(g => g.ActorName, actor329);
            db.SaveChanges();

            Actor actor330 = new Actor();
            actor330.ActorName = "Mandy Patinkin";
            db.Actors.AddOrUpdate(g => g.ActorName, actor330);
            db.SaveChanges();

            Actor actor331 = new Actor();
            actor331.ActorName = "Andre the Giant";
            db.Actors.AddOrUpdate(g => g.ActorName, actor331);
            db.SaveChanges();

            Actor actor332 = new Actor();
            actor332.ActorName = "Chris Sarandon";
            db.Actors.AddOrUpdate(g => g.ActorName, actor332);
            db.SaveChanges();

            Actor actor333 = new Actor();
            actor333.ActorName = "Christopher Guest";
            db.Actors.AddOrUpdate(g => g.ActorName, actor333);
            db.SaveChanges();

            Actor actor334 = new Actor();
            actor334.ActorName = "Tom Hanks";
            db.Actors.AddOrUpdate(g => g.ActorName, actor334);
            db.SaveChanges();

            Actor actor335 = new Actor();
            actor335.ActorName = "Elizabeth Perkins";
            db.Actors.AddOrUpdate(g => g.ActorName, actor335);
            db.SaveChanges();

            Actor actor336 = new Actor();
            actor336.ActorName = "Robert Loggia";
            db.Actors.AddOrUpdate(g => g.ActorName, actor336);
            db.SaveChanges();

            Actor actor337 = new Actor();
            actor337.ActorName = "John Heard";
            db.Actors.AddOrUpdate(g => g.ActorName, actor337);
            db.SaveChanges();

            Actor actor338 = new Actor();
            actor338.ActorName = "Jared Rushton";
            db.Actors.AddOrUpdate(g => g.ActorName, actor338);
            db.SaveChanges();

            Actor actor339 = new Actor();
            actor339.ActorName = "David Moscow";
            db.Actors.AddOrUpdate(g => g.ActorName, actor339);
            db.SaveChanges();

            Actor actor340 = new Actor();
            actor340.ActorName = "Gabriel Damon";
            db.Actors.AddOrUpdate(g => g.ActorName, actor340);
            db.SaveChanges();

            Actor actor341 = new Actor();
            actor341.ActorName = "Candace Hutson";
            db.Actors.AddOrUpdate(g => g.ActorName, actor341);
            db.SaveChanges();

            Actor actor342 = new Actor();
            actor342.ActorName = "Judith Barsi";
            db.Actors.AddOrUpdate(g => g.ActorName, actor342);
            db.SaveChanges();

            Actor actor343 = new Actor();
            actor343.ActorName = "Will Ryan";
            db.Actors.AddOrUpdate(g => g.ActorName, actor343);
            db.SaveChanges();

            Actor actor344 = new Actor();
            actor344.ActorName = "Pat Hingle";
            db.Actors.AddOrUpdate(g => g.ActorName, actor344);
            db.SaveChanges();

            Actor actor345 = new Actor();
            actor345.ActorName = "Helen Shaver";
            db.Actors.AddOrUpdate(g => g.ActorName, actor345);
            db.SaveChanges();

            Actor actor346 = new Actor();
            actor346.ActorName = "Dustin Hoffman";
            db.Actors.AddOrUpdate(g => g.ActorName, actor346);
            db.SaveChanges();

            Actor actor347 = new Actor();
            actor347.ActorName = "Valeria Golino";
            db.Actors.AddOrUpdate(g => g.ActorName, actor347);
            db.SaveChanges();

            Actor actor348 = new Actor();
            actor348.ActorName = "Gerald R. Molen";
            db.Actors.AddOrUpdate(g => g.ActorName, actor348);
            db.SaveChanges();

            Actor actor349 = new Actor();
            actor349.ActorName = "Jack Murdock";
            db.Actors.AddOrUpdate(g => g.ActorName, actor349);
            db.SaveChanges();

            Actor actor350 = new Actor();
            actor350.ActorName = "Michael D. Roberts";
            db.Actors.AddOrUpdate(g => g.ActorName, actor350);
            db.SaveChanges();

            Actor actor351 = new Actor();
            actor351.ActorName = "Keanu Reeves";
            db.Actors.AddOrUpdate(g => g.ActorName, actor351);
            db.SaveChanges();

            Actor actor352 = new Actor();
            actor352.ActorName = "Alex Winter";
            db.Actors.AddOrUpdate(g => g.ActorName, actor352);
            db.SaveChanges();

            Actor actor353 = new Actor();
            actor353.ActorName = "George Carlin";
            db.Actors.AddOrUpdate(g => g.ActorName, actor353);
            db.SaveChanges();

            Actor actor354 = new Actor();
            actor354.ActorName = "Dan Shor";
            db.Actors.AddOrUpdate(g => g.ActorName, actor354);
            db.SaveChanges();

            Actor actor355 = new Actor();
            actor355.ActorName = "Hal Landon Jr.";
            db.Actors.AddOrUpdate(g => g.ActorName, actor355);
            db.SaveChanges();

            Actor actor356 = new Actor();
            actor356.ActorName = "Amy Stock-Poynton";
            db.Actors.AddOrUpdate(g => g.ActorName, actor356);
            db.SaveChanges();

            Actor actor357 = new Actor();
            actor357.ActorName = "Robin Williams";
            db.Actors.AddOrUpdate(g => g.ActorName, actor357);
            db.SaveChanges();

            Actor actor358 = new Actor();
            actor358.ActorName = "Ethan Hawke";
            db.Actors.AddOrUpdate(g => g.ActorName, actor358);
            db.SaveChanges();

            Actor actor359 = new Actor();
            actor359.ActorName = "Robert Sean Leonard";
            db.Actors.AddOrUpdate(g => g.ActorName, actor359);
            db.SaveChanges();

            Actor actor360 = new Actor();
            actor360.ActorName = "Gale Hansen";
            db.Actors.AddOrUpdate(g => g.ActorName, actor360);
            db.SaveChanges();

            Actor actor361 = new Actor();
            actor361.ActorName = "Josh Charles";
            db.Actors.AddOrUpdate(g => g.ActorName, actor361);
            db.SaveChanges();

            Actor actor362 = new Actor();
            actor362.ActorName = "Dylan Kussman";
            db.Actors.AddOrUpdate(g => g.ActorName, actor362);
            db.SaveChanges();

            Actor actor363 = new Actor();
            actor363.ActorName = "Meg Ryan";
            db.Actors.AddOrUpdate(g => g.ActorName, actor363);
            db.SaveChanges();

            Actor actor364 = new Actor();
            actor364.ActorName = "Billy Crystal";
            db.Actors.AddOrUpdate(g => g.ActorName, actor364);
            db.SaveChanges();

            Actor actor365 = new Actor();
            actor365.ActorName = "Bruno Kirby";
            db.Actors.AddOrUpdate(g => g.ActorName, actor365);
            db.SaveChanges();

            Actor actor366 = new Actor();
            actor366.ActorName = "Steven Ford";
            db.Actors.AddOrUpdate(g => g.ActorName, actor366);
            db.SaveChanges();

            Actor actor367 = new Actor();
            actor367.ActorName = "Lisa Jane Persky";
            db.Actors.AddOrUpdate(g => g.ActorName, actor367);
            db.SaveChanges();

            Actor actor368 = new Actor();
            actor368.ActorName = "Elisabeth Shue";
            db.Actors.AddOrUpdate(g => g.ActorName, actor368);
            db.SaveChanges();

            Actor actor369 = new Actor();
            actor369.ActorName = "James Tolkan";
            db.Actors.AddOrUpdate(g => g.ActorName, actor369);
            db.SaveChanges();

            Actor actor370 = new Actor();
            actor370.ActorName = "Jeffrey Weissman";
            db.Actors.AddOrUpdate(g => g.ActorName, actor370);
            db.SaveChanges();

            Actor actor371 = new Actor();
            actor371.ActorName = "Mary Steenburgen";
            db.Actors.AddOrUpdate(g => g.ActorName, actor371);
            db.SaveChanges();

            Actor actor372 = new Actor();
            actor372.ActorName = "Elisabeth Shue";
            db.Actors.AddOrUpdate(g => g.ActorName, actor372);
            db.SaveChanges();

            Actor actor373 = new Actor();
            actor373.ActorName = "Kevin Costner";
            db.Actors.AddOrUpdate(g => g.ActorName, actor373);
            db.SaveChanges();

            Actor actor374 = new Actor();
            actor374.ActorName = "Morgan Freeman";
            db.Actors.AddOrUpdate(g => g.ActorName, actor374);
            db.SaveChanges();

            Actor actor375 = new Actor();
            actor375.ActorName = "Christian Slater";
            db.Actors.AddOrUpdate(g => g.ActorName, actor375);
            db.SaveChanges();

            Actor actor376 = new Actor();
            actor376.ActorName = "Mary Elizabeth Mastrantonio";
            db.Actors.AddOrUpdate(g => g.ActorName, actor376);
            db.SaveChanges();

            Actor actor377 = new Actor();
            actor377.ActorName = "Alan Rickman";
            db.Actors.AddOrUpdate(g => g.ActorName, actor377);
            db.SaveChanges();

            Actor actor378 = new Actor();
            actor378.ActorName = "Geraldine McEwan";
            db.Actors.AddOrUpdate(g => g.ActorName, actor378);
            db.SaveChanges();

            Actor actor379 = new Actor();
            actor379.ActorName = "Mike Myers";
            db.Actors.AddOrUpdate(g => g.ActorName, actor379);
            db.SaveChanges();

            Actor actor380 = new Actor();
            actor380.ActorName = "Dana Carvey";
            db.Actors.AddOrUpdate(g => g.ActorName, actor380);
            db.SaveChanges();

            Actor actor381 = new Actor();
            actor381.ActorName = "Rob Lowe";
            db.Actors.AddOrUpdate(g => g.ActorName, actor381);
            db.SaveChanges();

            Actor actor382 = new Actor();
            actor382.ActorName = "Tia Carrere";
            db.Actors.AddOrUpdate(g => g.ActorName, actor382);
            db.SaveChanges();

            Actor actor383 = new Actor();
            actor383.ActorName = "Lara Flynn Boyle";
            db.Actors.AddOrUpdate(g => g.ActorName, actor383);
            db.SaveChanges();

            Actor actor384 = new Actor();
            actor384.ActorName = "Chris Farley";
            db.Actors.AddOrUpdate(g => g.ActorName, actor384);
            db.SaveChanges();

            Actor actor385 = new Actor();
            actor385.ActorName = "Geena Davis";
            db.Actors.AddOrUpdate(g => g.ActorName, actor385);
            db.SaveChanges();

            Actor actor386 = new Actor();
            actor386.ActorName = "Madonna";
            db.Actors.AddOrUpdate(g => g.ActorName, actor386);
            db.SaveChanges();

            Actor actor387 = new Actor();
            actor387.ActorName = "Lori Petty";
            db.Actors.AddOrUpdate(g => g.ActorName, actor387);
            db.SaveChanges();

            Actor actor388 = new Actor();
            actor388.ActorName = "Jon Lovitz";
            db.Actors.AddOrUpdate(g => g.ActorName, actor388);
            db.SaveChanges();

            Actor actor389 = new Actor();
            actor389.ActorName = "David Strathairn";
            db.Actors.AddOrUpdate(g => g.ActorName, actor389);
            db.SaveChanges();

            Actor actor390 = new Actor();
            actor390.ActorName = "Daniel Day-Lewis";
            db.Actors.AddOrUpdate(g => g.ActorName, actor390);
            db.SaveChanges();

            Actor actor391 = new Actor();
            actor391.ActorName = "Madeleine Stowe";
            db.Actors.AddOrUpdate(g => g.ActorName, actor391);
            db.SaveChanges();

            Actor actor392 = new Actor();
            actor392.ActorName = "Russell Means";
            db.Actors.AddOrUpdate(g => g.ActorName, actor392);
            db.SaveChanges();

            Actor actor393 = new Actor();
            actor393.ActorName = "Eric Schweig";
            db.Actors.AddOrUpdate(g => g.ActorName, actor393);
            db.SaveChanges();

            Actor actor394 = new Actor();
            actor394.ActorName = "Jodhi May";
            db.Actors.AddOrUpdate(g => g.ActorName, actor394);
            db.SaveChanges();

            Actor actor395 = new Actor();
            actor395.ActorName = "Steven Waddington";
            db.Actors.AddOrUpdate(g => g.ActorName, actor395);
            db.SaveChanges();

            Actor actor396 = new Actor();
            actor396.ActorName = "Scott Weinger";
            db.Actors.AddOrUpdate(g => g.ActorName, actor396);
            db.SaveChanges();

            Actor actor397 = new Actor();
            actor397.ActorName = "Linda Larkin";
            db.Actors.AddOrUpdate(g => g.ActorName, actor397);
            db.SaveChanges();

            Actor actor398 = new Actor();
            actor398.ActorName = "Jonathan Freeman";
            db.Actors.AddOrUpdate(g => g.ActorName, actor398);
            db.SaveChanges();

            Actor actor399 = new Actor();
            actor399.ActorName = "Frank Welker";
            db.Actors.AddOrUpdate(g => g.ActorName, actor399);
            db.SaveChanges();

            Actor actor400 = new Actor();
            actor400.ActorName = "Gilbert Gottfried";
            db.Actors.AddOrUpdate(g => g.ActorName, actor400);
            db.SaveChanges();

            Actor actor401 = new Actor();
            actor401.ActorName = "Michael Caine";
            db.Actors.AddOrUpdate(g => g.ActorName, actor401);
            db.SaveChanges();

            Actor actor402 = new Actor();
            actor402.ActorName = "Don Austen";
            db.Actors.AddOrUpdate(g => g.ActorName, actor402);
            db.SaveChanges();

            Actor actor403 = new Actor();
            actor403.ActorName = "Meredith Braun";
            db.Actors.AddOrUpdate(g => g.ActorName, actor403);
            db.SaveChanges();

            Actor actor404 = new Actor();
            actor404.ActorName = "Ed Sanders";
            db.Actors.AddOrUpdate(g => g.ActorName, actor404);
            db.SaveChanges();

            Actor actor405 = new Actor();
            actor405.ActorName = "Dave Goelz";
            db.Actors.AddOrUpdate(g => g.ActorName, actor405);
            db.SaveChanges();

            Actor actor406 = new Actor();
            actor406.ActorName = "Demi Moore";
            db.Actors.AddOrUpdate(g => g.ActorName, actor406);
            db.SaveChanges();

            Actor actor407 = new Actor();
            actor407.ActorName = "Kevin Pollak";
            db.Actors.AddOrUpdate(g => g.ActorName, actor407);
            db.SaveChanges();

            Actor actor408 = new Actor();
            actor408.ActorName = "James Marshall";
            db.Actors.AddOrUpdate(g => g.ActorName, actor408);
            db.SaveChanges();

            Actor actor409 = new Actor();
            actor409.ActorName = "Sam Neill";
            db.Actors.AddOrUpdate(g => g.ActorName, actor409);
            db.SaveChanges();

            Actor actor410 = new Actor();
            actor410.ActorName = "Laura Dern";
            db.Actors.AddOrUpdate(g => g.ActorName, actor410);
            db.SaveChanges();

            Actor actor411 = new Actor();
            actor411.ActorName = "Jeff Goldblum";
            db.Actors.AddOrUpdate(g => g.ActorName, actor411);
            db.SaveChanges();

            Actor actor412 = new Actor();
            actor412.ActorName = "Richard Attenborough";
            db.Actors.AddOrUpdate(g => g.ActorName, actor412);
            db.SaveChanges();

            Actor actor413 = new Actor();
            actor413.ActorName = "Bob Peck";
            db.Actors.AddOrUpdate(g => g.ActorName, actor413);
            db.SaveChanges();

            Actor actor414 = new Actor();
            actor414.ActorName = "Martin Ferrero";
            db.Actors.AddOrUpdate(g => g.ActorName, actor414);
            db.SaveChanges();

            Actor actor415 = new Actor();
            actor415.ActorName = "Bette Midler";
            db.Actors.AddOrUpdate(g => g.ActorName, actor415);
            db.SaveChanges();

            Actor actor416 = new Actor();
            actor416.ActorName = "Kathy Najimy";
            db.Actors.AddOrUpdate(g => g.ActorName, actor416);
            db.SaveChanges();

            Actor actor417 = new Actor();
            actor417.ActorName = "Omri Katz";
            db.Actors.AddOrUpdate(g => g.ActorName, actor417);
            db.SaveChanges();

            Actor actor418 = new Actor();
            actor418.ActorName = "Thora Birch";
            db.Actors.AddOrUpdate(g => g.ActorName, actor418);
            db.SaveChanges();

            Actor actor419 = new Actor();
            actor419.ActorName = "Vinessa Shaw";
            db.Actors.AddOrUpdate(g => g.ActorName, actor419);
            db.SaveChanges();

            Actor actor420 = new Actor();
            actor420.ActorName = "Jason London";
            db.Actors.AddOrUpdate(g => g.ActorName, actor420);
            db.SaveChanges();

            Actor actor421 = new Actor();
            actor421.ActorName = "Rory Cochrane";
            db.Actors.AddOrUpdate(g => g.ActorName, actor421);
            db.SaveChanges();

            Actor actor422 = new Actor();
            actor422.ActorName = "Wiley Wiggins";
            db.Actors.AddOrUpdate(g => g.ActorName, actor422);
            db.SaveChanges();

            Actor actor423 = new Actor();
            actor423.ActorName = "Sasha Jenson";
            db.Actors.AddOrUpdate(g => g.ActorName, actor423);
            db.SaveChanges();

            Actor actor424 = new Actor();
            actor424.ActorName = "Michelle Burke";
            db.Actors.AddOrUpdate(g => g.ActorName, actor424);
            db.SaveChanges();

            Actor actor425 = new Actor();
            actor425.ActorName = "Adam Goldberg";
            db.Actors.AddOrUpdate(g => g.ActorName, actor425);
            db.SaveChanges();

            Actor actor426 = new Actor();
            actor426.ActorName = "Hugh Grant";
            db.Actors.AddOrUpdate(g => g.ActorName, actor426);
            db.SaveChanges();

            Actor actor427 = new Actor();
            actor427.ActorName = "Andie MacDowell";
            db.Actors.AddOrUpdate(g => g.ActorName, actor427);
            db.SaveChanges();

            Actor actor428 = new Actor();
            actor428.ActorName = "James Fleet";
            db.Actors.AddOrUpdate(g => g.ActorName, actor428);
            db.SaveChanges();

            Actor actor429 = new Actor();
            actor429.ActorName = "Simon Callow";
            db.Actors.AddOrUpdate(g => g.ActorName, actor429);
            db.SaveChanges();

            Actor actor430 = new Actor();
            actor430.ActorName = "John Hannah";
            db.Actors.AddOrUpdate(g => g.ActorName, actor430);
            db.SaveChanges();

            Actor actor431 = new Actor();
            actor431.ActorName = "Kristin Scott Thomas";
            db.Actors.AddOrUpdate(g => g.ActorName, actor431);
            db.SaveChanges();

            Actor actor432 = new Actor();
            actor432.ActorName = "Jonathan Taylor Thomas";
            db.Actors.AddOrUpdate(g => g.ActorName, actor432);
            db.SaveChanges();

            Actor actor433 = new Actor();
            actor433.ActorName = "James Earl Jones";
            db.Actors.AddOrUpdate(g => g.ActorName, actor433);
            db.SaveChanges();

            Actor actor434 = new Actor();
            actor434.ActorName = "Jeremy Irons";
            db.Actors.AddOrUpdate(g => g.ActorName, actor434);
            db.SaveChanges();

            Actor actor435 = new Actor();
            actor435.ActorName = "Moira Kelly";
            db.Actors.AddOrUpdate(g => g.ActorName, actor435);
            db.SaveChanges();

            Actor actor436 = new Actor();
            actor436.ActorName = "Niketa Calame";
            db.Actors.AddOrUpdate(g => g.ActorName, actor436);
            db.SaveChanges();

            Actor actor437 = new Actor();
            actor437.ActorName = "Gary Sinise";
            db.Actors.AddOrUpdate(g => g.ActorName, actor437);
            db.SaveChanges();

            Actor actor438 = new Actor();
            actor438.ActorName = "Mykelti Williamson";
            db.Actors.AddOrUpdate(g => g.ActorName, actor438);
            db.SaveChanges();

            Actor actor439 = new Actor();
            actor439.ActorName = "Sally Field";
            db.Actors.AddOrUpdate(g => g.ActorName, actor439);
            db.SaveChanges();

            Actor actor440 = new Actor();
            actor440.ActorName = "Michael Conner Humphreys";
            db.Actors.AddOrUpdate(g => g.ActorName, actor440);
            db.SaveChanges();

            Actor actor441 = new Actor();
            actor441.ActorName = "Tim Robbins";
            db.Actors.AddOrUpdate(g => g.ActorName, actor441);
            db.SaveChanges();

            Actor actor442 = new Actor();
            actor442.ActorName = "Bob Gunton";
            db.Actors.AddOrUpdate(g => g.ActorName, actor442);
            db.SaveChanges();

            Actor actor443 = new Actor();
            actor443.ActorName = "Clancy Brown";
            db.Actors.AddOrUpdate(g => g.ActorName, actor443);
            db.SaveChanges();

            Actor actor444 = new Actor();
            actor444.ActorName = "Mark Rolston";
            db.Actors.AddOrUpdate(g => g.ActorName, actor444);
            db.SaveChanges();

            Actor actor445 = new Actor();
            actor445.ActorName = "James Whitmore";
            db.Actors.AddOrUpdate(g => g.ActorName, actor445);
            db.SaveChanges();

            Actor actor446 = new Actor();
            actor446.ActorName = "Samuel L. Jackson";
            db.Actors.AddOrUpdate(g => g.ActorName, actor446);
            db.SaveChanges();

            Actor actor447 = new Actor();
            actor447.ActorName = "Uma Thurman";
            db.Actors.AddOrUpdate(g => g.ActorName, actor447);
            db.SaveChanges();

            Actor actor448 = new Actor();
            actor448.ActorName = "Bruce Willis";
            db.Actors.AddOrUpdate(g => g.ActorName, actor448);
            db.SaveChanges();

            Actor actor449 = new Actor();
            actor449.ActorName = "Ving Rhames";
            db.Actors.AddOrUpdate(g => g.ActorName, actor449);
            db.SaveChanges();

            Actor actor450 = new Actor();
            actor450.ActorName = "Harvey Keitel";
            db.Actors.AddOrUpdate(g => g.ActorName, actor450);
            db.SaveChanges();

            Actor actor451 = new Actor();
            actor451.ActorName = "Stephen Baldwin";
            db.Actors.AddOrUpdate(g => g.ActorName, actor451);
            db.SaveChanges();

            Actor actor452 = new Actor();
            actor452.ActorName = "Gabriel Byrne";
            db.Actors.AddOrUpdate(g => g.ActorName, actor452);
            db.SaveChanges();

            Actor actor453 = new Actor();
            actor453.ActorName = "Chazz Palminteri";
            db.Actors.AddOrUpdate(g => g.ActorName, actor453);
            db.SaveChanges();

            Actor actor454 = new Actor();
            actor454.ActorName = "Pete Postlethwaite";
            db.Actors.AddOrUpdate(g => g.ActorName, actor454);
            db.SaveChanges();

            Actor actor455 = new Actor();
            actor455.ActorName = "Kevin Spacey";
            db.Actors.AddOrUpdate(g => g.ActorName, actor455);
            db.SaveChanges();

            Actor actor456 = new Actor();
            actor456.ActorName = "Tim Allen";
            db.Actors.AddOrUpdate(g => g.ActorName, actor456);
            db.SaveChanges();

            Actor actor457 = new Actor();
            actor457.ActorName = "Don Rickles";
            db.Actors.AddOrUpdate(g => g.ActorName, actor457);
            db.SaveChanges();

            Actor actor458 = new Actor();
            actor458.ActorName = "Jim Varney";
            db.Actors.AddOrUpdate(g => g.ActorName, actor458);
            db.SaveChanges();

            Actor actor459 = new Actor();
            actor459.ActorName = "Wallace Shawn";
            db.Actors.AddOrUpdate(g => g.ActorName, actor459);
            db.SaveChanges();

            Actor actor460 = new Actor();
            actor460.ActorName = "John Ratzenberger";
            db.Actors.AddOrUpdate(g => g.ActorName, actor460);
            db.SaveChanges();

            Actor actor461 = new Actor();
            actor461.ActorName = "Kate Winslet";
            db.Actors.AddOrUpdate(g => g.ActorName, actor461);
            db.SaveChanges();

            Actor actor462 = new Actor();
            actor462.ActorName = "Emma Thompson";
            db.Actors.AddOrUpdate(g => g.ActorName, actor462);
            db.SaveChanges();

            Actor actor463 = new Actor();
            actor463.ActorName = "Tom Wilkinson";
            db.Actors.AddOrUpdate(g => g.ActorName, actor463);
            db.SaveChanges();

            Actor actor464 = new Actor();
            actor464.ActorName = "Imogen Stubbs";
            db.Actors.AddOrUpdate(g => g.ActorName, actor464);
            db.SaveChanges();

            Actor actor465 = new Actor();
            actor465.ActorName = "Jon Voight";
            db.Actors.AddOrUpdate(g => g.ActorName, actor465);
            db.SaveChanges();

            Actor actor466 = new Actor();
            actor466.ActorName = "Emmanuelle Beart";
            db.Actors.AddOrUpdate(g => g.ActorName, actor466);
            db.SaveChanges();

            Actor actor467 = new Actor();
            actor467.ActorName = "Henry Czerny";
            db.Actors.AddOrUpdate(g => g.ActorName, actor467);
            db.SaveChanges();

            Actor actor468 = new Actor();
            actor468.ActorName = "Jean Reno";
            db.Actors.AddOrUpdate(g => g.ActorName, actor468);
            db.SaveChanges();

            Actor actor469 = new Actor();
            actor469.ActorName = "Ving Rhames";
            db.Actors.AddOrUpdate(g => g.ActorName, actor469);
            db.SaveChanges();

            Actor actor470 = new Actor();
            actor470.ActorName = "Will Smith";
            db.Actors.AddOrUpdate(g => g.ActorName, actor470);
            db.SaveChanges();

            Actor actor471 = new Actor();
            actor471.ActorName = "Mary McDonnell";
            db.Actors.AddOrUpdate(g => g.ActorName, actor471);
            db.SaveChanges();

            Actor actor472 = new Actor();
            actor472.ActorName = "Judd Hirsch";
            db.Actors.AddOrUpdate(g => g.ActorName, actor472);
            db.SaveChanges();

            Actor actor473 = new Actor();
            actor473.ActorName = "Robert Loggia";
            db.Actors.AddOrUpdate(g => g.ActorName, actor473);
            db.SaveChanges();

            Actor actor474 = new Actor();
            actor474.ActorName = "Elizabeth Hurley";
            db.Actors.AddOrUpdate(g => g.ActorName, actor474);
            db.SaveChanges();

            Actor actor475 = new Actor();
            actor475.ActorName = "Michael York";
            db.Actors.AddOrUpdate(g => g.ActorName, actor475);
            db.SaveChanges();

            Actor actor476 = new Actor();
            actor476.ActorName = "Mimi Rogers";
            db.Actors.AddOrUpdate(g => g.ActorName, actor476);
            db.SaveChanges();

            Actor actor477 = new Actor();
            actor477.ActorName = "Seth Green";
            db.Actors.AddOrUpdate(g => g.ActorName, actor477);
            db.SaveChanges();

            Actor actor478 = new Actor();
            actor478.ActorName = "Fabiana Udenio";
            db.Actors.AddOrUpdate(g => g.ActorName, actor478);
            db.SaveChanges();

            Actor actor479 = new Actor();
            actor479.ActorName = "Tommy Lee Jones";
            db.Actors.AddOrUpdate(g => g.ActorName, actor479);
            db.SaveChanges();

            Actor actor480 = new Actor();
            actor480.ActorName = "Linda Fiorentino";
            db.Actors.AddOrUpdate(g => g.ActorName, actor480);
            db.SaveChanges();

            Actor actor481 = new Actor();
            actor481.ActorName = "Vincent D'Onofrio";
            db.Actors.AddOrUpdate(g => g.ActorName, actor481);
            db.SaveChanges();

            Actor actor482 = new Actor();
            actor482.ActorName = "Rip Torn";
            db.Actors.AddOrUpdate(g => g.ActorName, actor482);
            db.SaveChanges();

            Actor actor483 = new Actor();
            actor483.ActorName = "Tony Shalhoub";
            db.Actors.AddOrUpdate(g => g.ActorName, actor483);
            db.SaveChanges();

            Actor actor484 = new Actor();
            actor484.ActorName = "Leonardo DiCaprio";
            db.Actors.AddOrUpdate(g => g.ActorName, actor484);
            db.SaveChanges();

            Actor actor485 = new Actor();
            actor485.ActorName = "Frances Fisher";
            db.Actors.AddOrUpdate(g => g.ActorName, actor485);
            db.SaveChanges();

            Actor actor486 = new Actor();
            actor486.ActorName = "Billy Zane";
            db.Actors.AddOrUpdate(g => g.ActorName, actor486);
            db.SaveChanges();

            Actor actor487 = new Actor();
            actor487.ActorName = "Kathy Bates";
            db.Actors.AddOrUpdate(g => g.ActorName, actor487);
            db.SaveChanges();

            Actor actor488 = new Actor();
            actor488.ActorName = "Gloria Stuart";
            db.Actors.AddOrUpdate(g => g.ActorName, actor488);
            db.SaveChanges();

            Actor actor489 = new Actor();
            actor489.ActorName = "Jeff Bridges";
            db.Actors.AddOrUpdate(g => g.ActorName, actor489);
            db.SaveChanges();

            Actor actor490 = new Actor();
            actor490.ActorName = "John Goodman";
            db.Actors.AddOrUpdate(g => g.ActorName, actor490);
            db.SaveChanges();

            Actor actor491 = new Actor();
            actor491.ActorName = "Julianne Moore";
            db.Actors.AddOrUpdate(g => g.ActorName, actor491);
            db.SaveChanges();

            Actor actor492 = new Actor();
            actor492.ActorName = "Steve Buscemi";
            db.Actors.AddOrUpdate(g => g.ActorName, actor492);
            db.SaveChanges();

            Actor actor493 = new Actor();
            actor493.ActorName = "Philip Seymour Hoffman";
            db.Actors.AddOrUpdate(g => g.ActorName, actor493);
            db.SaveChanges();

            Actor actor494 = new Actor();
            actor494.ActorName = "David Huddleston";
            db.Actors.AddOrUpdate(g => g.ActorName, actor494);
            db.SaveChanges();

            Actor actor495 = new Actor();
            actor495.ActorName = "Joseph Fiennes";
            db.Actors.AddOrUpdate(g => g.ActorName, actor495);
            db.SaveChanges();

            Actor actor496 = new Actor();
            actor496.ActorName = "Gwyneth Paltrow";
            db.Actors.AddOrUpdate(g => g.ActorName, actor496);
            db.SaveChanges();

            Actor actor497 = new Actor();
            actor497.ActorName = "Geoffrey Rush";
            db.Actors.AddOrUpdate(g => g.ActorName, actor497);
            db.SaveChanges();

            Actor actor498 = new Actor();
            actor498.ActorName = "Judi Dench";
            db.Actors.AddOrUpdate(g => g.ActorName, actor498);
            db.SaveChanges();

            Actor actor499 = new Actor();
            actor499.ActorName = "Imelda Staunton";
            db.Actors.AddOrUpdate(g => g.ActorName, actor499);
            db.SaveChanges();

            Actor actor500 = new Actor();
            actor500.ActorName = "Katie Sagona";
            db.Actors.AddOrUpdate(g => g.ActorName, actor500);
            db.SaveChanges();

            Actor actor501 = new Actor();
            actor501.ActorName = "Greg Kinnear";
            db.Actors.AddOrUpdate(g => g.ActorName, actor501);
            db.SaveChanges();

            Actor actor502 = new Actor();
            actor502.ActorName = "Parker Posey";
            db.Actors.AddOrUpdate(g => g.ActorName, actor502);
            db.SaveChanges();

            Actor actor503 = new Actor();
            actor503.ActorName = "Jean Stapleton";
            db.Actors.AddOrUpdate(g => g.ActorName, actor503);
            db.SaveChanges();

            Actor actor504 = new Actor();
            actor504.ActorName = "Ron Livingston";
            db.Actors.AddOrUpdate(g => g.ActorName, actor504);
            db.SaveChanges();

            Actor actor505 = new Actor();
            actor505.ActorName = "Jennifer Aniston";
            db.Actors.AddOrUpdate(g => g.ActorName, actor505);
            db.SaveChanges();

            Actor actor506 = new Actor();
            actor506.ActorName = "David Herman";
            db.Actors.AddOrUpdate(g => g.ActorName, actor506);
            db.SaveChanges();

            Actor actor507 = new Actor();
            actor507.ActorName = "Ajay Naidu";
            db.Actors.AddOrUpdate(g => g.ActorName, actor507);
            db.SaveChanges();

            Actor actor508 = new Actor();
            actor508.ActorName = "Diedrich Bader";
            db.Actors.AddOrUpdate(g => g.ActorName, actor508);
            db.SaveChanges();

            Actor actor509 = new Actor();
            actor509.ActorName = "Stephen Root";
            db.Actors.AddOrUpdate(g => g.ActorName, actor509);
            db.SaveChanges();

            Actor actor510 = new Actor();
            actor510.ActorName = "Julia Roberts";
            db.Actors.AddOrUpdate(g => g.ActorName, actor510);
            db.SaveChanges();

            Actor actor511 = new Actor();
            actor511.ActorName = "Gina McKee";
            db.Actors.AddOrUpdate(g => g.ActorName, actor511);
            db.SaveChanges();

            Actor actor512 = new Actor();
            actor512.ActorName = "Tim McInnerny";
            db.Actors.AddOrUpdate(g => g.ActorName, actor512);
            db.SaveChanges();

            Actor actor513 = new Actor();
            actor513.ActorName = "Rhys Ifans";
            db.Actors.AddOrUpdate(g => g.ActorName, actor513);
            db.SaveChanges();

            Actor actor514 = new Actor();
            actor514.ActorName = "Emma Chambers";
            db.Actors.AddOrUpdate(g => g.ActorName, actor514);
            db.SaveChanges();

            Actor actor515 = new Actor();
            actor515.ActorName = "Joan Cusack";
            db.Actors.AddOrUpdate(g => g.ActorName, actor515);
            db.SaveChanges();

            Actor actor516 = new Actor();
            actor516.ActorName = "Kelsey Grammer";
            db.Actors.AddOrUpdate(g => g.ActorName, actor516);
            db.SaveChanges();

            Actor actor517 = new Actor();
            actor517.ActorName = "Jim Varney";
            db.Actors.AddOrUpdate(g => g.ActorName, actor517);
            db.SaveChanges();

            Actor actor518 = new Actor();
            actor518.ActorName = "Russell Crowe";
            db.Actors.AddOrUpdate(g => g.ActorName, actor518);
            db.SaveChanges();

            Actor actor519 = new Actor();
            actor519.ActorName = "Joaquin Phoenix";
            db.Actors.AddOrUpdate(g => g.ActorName, actor519);
            db.SaveChanges();

            Actor actor520 = new Actor();
            actor520.ActorName = "Connie Nielsen";
            db.Actors.AddOrUpdate(g => g.ActorName, actor520);
            db.SaveChanges();

            Actor actor521 = new Actor();
            actor521.ActorName = "Oliver Reed";
            db.Actors.AddOrUpdate(g => g.ActorName, actor521);
            db.SaveChanges();

            Actor actor522 = new Actor();
            actor522.ActorName = "Richard Harris";
            db.Actors.AddOrUpdate(g => g.ActorName, actor522);
            db.SaveChanges();

            Actor actor523 = new Actor();
            actor523.ActorName = "Derek Jacobi";
            db.Actors.AddOrUpdate(g => g.ActorName, actor523);
            db.SaveChanges();

            Actor actor524 = new Actor();
            actor524.ActorName = "Nicolas Cage";
            db.Actors.AddOrUpdate(g => g.ActorName, actor524);
            db.SaveChanges();

            Actor actor525 = new Actor();
            actor525.ActorName = "Angelina Jolie";
            db.Actors.AddOrUpdate(g => g.ActorName, actor525);
            db.SaveChanges();

            Actor actor526 = new Actor();
            actor526.ActorName = "Giovanni Ribisi";
            db.Actors.AddOrUpdate(g => g.ActorName, actor526);
            db.SaveChanges();

            Actor actor527 = new Actor();
            actor527.ActorName = "Delroy Lindo";
            db.Actors.AddOrUpdate(g => g.ActorName, actor527);
            db.SaveChanges();

            Actor actor528 = new Actor();
            actor528.ActorName = "Will Patton";
            db.Actors.AddOrUpdate(g => g.ActorName, actor528);
            db.SaveChanges();

            Actor actor529 = new Actor();
            actor529.ActorName = "Christopher Eccleston";
            db.Actors.AddOrUpdate(g => g.ActorName, actor529);
            db.SaveChanges();

            Actor actor530 = new Actor();
            actor530.ActorName = "Patrick Stewart";
            db.Actors.AddOrUpdate(g => g.ActorName, actor530);
            db.SaveChanges();

            Actor actor531 = new Actor();
            actor531.ActorName = "Hugh Jackman";
            db.Actors.AddOrUpdate(g => g.ActorName, actor531);
            db.SaveChanges();

            Actor actor532 = new Actor();
            actor532.ActorName = "Ian McKellen";
            db.Actors.AddOrUpdate(g => g.ActorName, actor532);
            db.SaveChanges();

            Actor actor533 = new Actor();
            actor533.ActorName = "Halle Berry";
            db.Actors.AddOrUpdate(g => g.ActorName, actor533);
            db.SaveChanges();

            Actor actor534 = new Actor();
            actor534.ActorName = "Famke Janssen";
            db.Actors.AddOrUpdate(g => g.ActorName, actor534);
            db.SaveChanges();

            Actor actor535 = new Actor();
            actor535.ActorName = "James Marsden";
            db.Actors.AddOrUpdate(g => g.ActorName, actor535);
            db.SaveChanges();

            Actor actor536 = new Actor();
            actor536.ActorName = "Sandra Bullock";
            db.Actors.AddOrUpdate(g => g.ActorName, actor536);
            db.SaveChanges();

            Actor actor537 = new Actor();
            actor537.ActorName = "Benjamin Bratt";
            db.Actors.AddOrUpdate(g => g.ActorName, actor537);
            db.SaveChanges();

            Actor actor538 = new Actor();
            actor538.ActorName = "Candice Bergen";
            db.Actors.AddOrUpdate(g => g.ActorName, actor538);
            db.SaveChanges();

            Actor actor539 = new Actor();
            actor539.ActorName = "William Shatner";
            db.Actors.AddOrUpdate(g => g.ActorName, actor539);
            db.SaveChanges();

            Actor actor540 = new Actor();
            actor540.ActorName = "Ernie Hudson";
            db.Actors.AddOrUpdate(g => g.ActorName, actor540);
            db.SaveChanges();

            Actor actor541 = new Actor();
            actor541.ActorName = "Renee Zellweger";
            db.Actors.AddOrUpdate(g => g.ActorName, actor541);
            db.SaveChanges();

            Actor actor542 = new Actor();
            actor542.ActorName = "Colin Firth";
            db.Actors.AddOrUpdate(g => g.ActorName, actor542);
            db.SaveChanges();

            Actor actor543 = new Actor();
            actor543.ActorName = "Gemma Jones";
            db.Actors.AddOrUpdate(g => g.ActorName, actor543);
            db.SaveChanges();

            Actor actor544 = new Actor();
            actor544.ActorName = "Jim Broadbent";
            db.Actors.AddOrUpdate(g => g.ActorName, actor544);
            db.SaveChanges();

            Actor actor545 = new Actor();
            actor545.ActorName = "James Callis";
            db.Actors.AddOrUpdate(g => g.ActorName, actor545);
            db.SaveChanges();

            Actor actor546 = new Actor();
            actor546.ActorName = "Reese Witherspoon";
            db.Actors.AddOrUpdate(g => g.ActorName, actor546);
            db.SaveChanges();

            Actor actor547 = new Actor();
            actor547.ActorName = "Luke Wilson";
            db.Actors.AddOrUpdate(g => g.ActorName, actor547);
            db.SaveChanges();

            Actor actor548 = new Actor();
            actor548.ActorName = "Selma Blair";
            db.Actors.AddOrUpdate(g => g.ActorName, actor548);
            db.SaveChanges();

            Actor actor549 = new Actor();
            actor549.ActorName = "Matthew Davis";
            db.Actors.AddOrUpdate(g => g.ActorName, actor549);
            db.SaveChanges();

            Actor actor550 = new Actor();
            actor550.ActorName = "Victor Garber";
            db.Actors.AddOrUpdate(g => g.ActorName, actor550);
            db.SaveChanges();

            Actor actor551 = new Actor();
            actor551.ActorName = "Jennifer Coolidge";
            db.Actors.AddOrUpdate(g => g.ActorName, actor551);
            db.SaveChanges();

            Actor actor552 = new Actor();
            actor552.ActorName = "Mary Gibbs";
            db.Actors.AddOrUpdate(g => g.ActorName, actor552);
            db.SaveChanges();

            Actor actor553 = new Actor();
            actor553.ActorName = "James Coburn";
            db.Actors.AddOrUpdate(g => g.ActorName, actor553);
            db.SaveChanges();

            Actor actor554 = new Actor();
            actor554.ActorName = "Jennifer Tilly";
            db.Actors.AddOrUpdate(g => g.ActorName, actor554);
            db.SaveChanges();

            Actor actor555 = new Actor();
            actor555.ActorName = "Daniel Radcliffe";
            db.Actors.AddOrUpdate(g => g.ActorName, actor555);
            db.SaveChanges();

            Actor actor556 = new Actor();
            actor556.ActorName = "Rupert Grint";
            db.Actors.AddOrUpdate(g => g.ActorName, actor556);
            db.SaveChanges();

            Actor actor557 = new Actor();
            actor557.ActorName = "Emma Watson";
            db.Actors.AddOrUpdate(g => g.ActorName, actor557);
            db.SaveChanges();

            Actor actor558 = new Actor();
            actor558.ActorName = "Tom Felton";
            db.Actors.AddOrUpdate(g => g.ActorName, actor558);
            db.SaveChanges();

            Actor actor559 = new Actor();
            actor559.ActorName = "Robbie Coltrane";
            db.Actors.AddOrUpdate(g => g.ActorName, actor559);
            db.SaveChanges();

            Actor actor560 = new Actor();
            actor560.ActorName = "George Clooney";
            db.Actors.AddOrUpdate(g => g.ActorName, actor560);
            db.SaveChanges();

            Actor actor561 = new Actor();
            actor561.ActorName = "Brad Pitt";
            db.Actors.AddOrUpdate(g => g.ActorName, actor561);
            db.SaveChanges();

            Actor actor562 = new Actor();
            actor562.ActorName = "Matt Damon";
            db.Actors.AddOrUpdate(g => g.ActorName, actor562);
            db.SaveChanges();

            Actor actor563 = new Actor();
            actor563.ActorName = "Andy Garcia";
            db.Actors.AddOrUpdate(g => g.ActorName, actor563);
            db.SaveChanges();

            Actor actor564 = new Actor();
            actor564.ActorName = "Casey Affleck";
            db.Actors.AddOrUpdate(g => g.ActorName, actor564);
            db.SaveChanges();

            Actor actor565 = new Actor();
            actor565.ActorName = "Tom Felton";
            db.Actors.AddOrUpdate(g => g.ActorName, actor565);
            db.SaveChanges();

            Actor actor566 = new Actor();
            actor566.ActorName = "Albert Brooks";
            db.Actors.AddOrUpdate(g => g.ActorName, actor566);
            db.SaveChanges();

            Actor actor567 = new Actor();
            actor567.ActorName = "Ellen DeGeneres";
            db.Actors.AddOrUpdate(g => g.ActorName, actor567);
            db.SaveChanges();

            Actor actor568 = new Actor();
            actor568.ActorName = "Alexander Gould";
            db.Actors.AddOrUpdate(g => g.ActorName, actor568);
            db.SaveChanges();

            Actor actor569 = new Actor();
            actor569.ActorName = "Willem Dafoe";
            db.Actors.AddOrUpdate(g => g.ActorName, actor569);
            db.SaveChanges();

            Actor actor570 = new Actor();
            actor570.ActorName = "Brad Garrett";
            db.Actors.AddOrUpdate(g => g.ActorName, actor570);
            db.SaveChanges();

            Actor actor571 = new Actor();
            actor571.ActorName = "Allison Janney";
            db.Actors.AddOrUpdate(g => g.ActorName, actor571);
            db.SaveChanges();

            Actor actor572 = new Actor();
            actor572.ActorName = "Keira Knightley";
            db.Actors.AddOrUpdate(g => g.ActorName, actor572);
            db.SaveChanges();

            Actor actor573 = new Actor();
            actor573.ActorName = "Heike Makatsch";
            db.Actors.AddOrUpdate(g => g.ActorName, actor573);
            db.SaveChanges();

            Actor actor574 = new Actor();
            actor574.ActorName = "Laura Linney";
            db.Actors.AddOrUpdate(g => g.ActorName, actor574);
            db.SaveChanges();

            Actor actor575 = new Actor();
            actor575.ActorName = "January Jones";
            db.Actors.AddOrUpdate(g => g.ActorName, actor575);
            db.SaveChanges();

            Actor actor576 = new Actor();
            actor576.ActorName = "Will Ferrell";
            db.Actors.AddOrUpdate(g => g.ActorName, actor576);
            db.SaveChanges();

            Actor actor577 = new Actor();
            actor577.ActorName = "James Caan";
            db.Actors.AddOrUpdate(g => g.ActorName, actor577);
            db.SaveChanges();

            Actor actor578 = new Actor();
            actor578.ActorName = "Zooey Deschanel";
            db.Actors.AddOrUpdate(g => g.ActorName, actor578);
            db.SaveChanges();

            Actor actor579 = new Actor();
            actor579.ActorName = "Daniel Tay";
            db.Actors.AddOrUpdate(g => g.ActorName, actor579);
            db.SaveChanges();

            Actor actor580 = new Actor();
            actor580.ActorName = "Ed Asner";
            db.Actors.AddOrUpdate(g => g.ActorName, actor580);
            db.SaveChanges();

            Actor actor581 = new Actor();
            actor581.ActorName = "Lindsay Lohan";
            db.Actors.AddOrUpdate(g => g.ActorName, actor581);
            db.SaveChanges();

            Actor actor582 = new Actor();
            actor582.ActorName = "Rachel McAdams";
            db.Actors.AddOrUpdate(g => g.ActorName, actor582);
            db.SaveChanges();

            Actor actor583 = new Actor();
            actor583.ActorName = "Tim Meadows";
            db.Actors.AddOrUpdate(g => g.ActorName, actor583);
            db.SaveChanges();

            Actor actor584 = new Actor();
            actor584.ActorName = "Ana Gasteyer";
            db.Actors.AddOrUpdate(g => g.ActorName, actor584);
            db.SaveChanges();

            Actor actor585 = new Actor();
            actor585.ActorName = "Amy Poehler";
            db.Actors.AddOrUpdate(g => g.ActorName, actor585);
            db.SaveChanges();

            Actor actor586 = new Actor();
            actor586.ActorName = "Tina Fey";
            db.Actors.AddOrUpdate(g => g.ActorName, actor586);
            db.SaveChanges();

            Actor actor587 = new Actor();
            actor587.ActorName = "Gary Oldman";
            db.Actors.AddOrUpdate(g => g.ActorName, actor587);
            db.SaveChanges();

            Actor actor588 = new Actor();
            actor588.ActorName = "David Thewlis";
            db.Actors.AddOrUpdate(g => g.ActorName, actor588);
            db.SaveChanges();

            Actor actor589 = new Actor();
            actor589.ActorName = "Alan Rickman";
            db.Actors.AddOrUpdate(g => g.ActorName, actor589);
            db.SaveChanges();

            Actor actor590 = new Actor();
            actor590.ActorName = "Ralph Fiennes";
            db.Actors.AddOrUpdate(g => g.ActorName, actor590);
            db.SaveChanges();

            Actor actor591 = new Actor();
            actor591.ActorName = "Michael Gambon";
            db.Actors.AddOrUpdate(g => g.ActorName, actor591);
            db.SaveChanges();

            Actor actor592 = new Actor();
            actor592.ActorName = "Alan Rickman";
            db.Actors.AddOrUpdate(g => g.ActorName, actor592);
            db.SaveChanges();

            Actor actor593 = new Actor();
            actor593.ActorName = "Owen Wilson";
            db.Actors.AddOrUpdate(g => g.ActorName, actor593);
            db.SaveChanges();

            Actor actor594 = new Actor();
            actor594.ActorName = "Bonnie Hunt";
            db.Actors.AddOrUpdate(g => g.ActorName, actor594);
            db.SaveChanges();

            Actor actor595 = new Actor();
            actor595.ActorName = "Larry the Cable Guy";
            db.Actors.AddOrUpdate(g => g.ActorName, actor595);
            db.SaveChanges();

            Actor actor596 = new Actor();
            actor596.ActorName = "Cheech Marin";
            db.Actors.AddOrUpdate(g => g.ActorName, actor596);
            db.SaveChanges();

            Actor actor597 = new Actor();
            actor597.ActorName = "Mark Wahlberg";
            db.Actors.AddOrUpdate(g => g.ActorName, actor597);
            db.SaveChanges();

            Actor actor598 = new Actor();
            actor598.ActorName = "Ray Winstone";
            db.Actors.AddOrUpdate(g => g.ActorName, actor598);
            db.SaveChanges();

            Actor actor599 = new Actor();
            actor599.ActorName = "Patton Oswalt";
            db.Actors.AddOrUpdate(g => g.ActorName, actor599);
            db.SaveChanges();

            Actor actor600 = new Actor();
            actor600.ActorName = "Lou Romano";
            db.Actors.AddOrUpdate(g => g.ActorName, actor600);
            db.SaveChanges();

            Actor actor601 = new Actor();
            actor601.ActorName = "Brian Dennehy";
            db.Actors.AddOrUpdate(g => g.ActorName, actor601);
            db.SaveChanges();

            Actor actor602 = new Actor();
            actor602.ActorName = "Peter Sohn";
            db.Actors.AddOrUpdate(g => g.ActorName, actor602);
            db.SaveChanges();

            Actor actor603 = new Actor();
            actor603.ActorName = "Peter O'Toole";
            db.Actors.AddOrUpdate(g => g.ActorName, actor603);
            db.SaveChanges();

            Actor actor604 = new Actor();
            actor604.ActorName = "Shia LaBeouf";
            db.Actors.AddOrUpdate(g => g.ActorName, actor604);
            db.SaveChanges();

            Actor actor605 = new Actor();
            actor605.ActorName = "Josh Duhamel";
            db.Actors.AddOrUpdate(g => g.ActorName, actor605);
            db.SaveChanges();

            Actor actor606 = new Actor();
            actor606.ActorName = "Megan Fox";
            db.Actors.AddOrUpdate(g => g.ActorName, actor606);
            db.SaveChanges();

            Actor actor607 = new Actor();
            actor607.ActorName = "Rachael Taylor";
            db.Actors.AddOrUpdate(g => g.ActorName, actor607);
            db.SaveChanges();

            Actor actor608 = new Actor();
            actor608.ActorName = "Tyrese Gibson";
            db.Actors.AddOrUpdate(g => g.ActorName, actor608);
            db.SaveChanges();

            Actor actor609 = new Actor();
            actor609.ActorName = "Jon Voight";
            db.Actors.AddOrUpdate(g => g.ActorName, actor609);
            db.SaveChanges();

            Actor actor610 = new Actor();
            actor610.ActorName = "Tom Felton";
            db.Actors.AddOrUpdate(g => g.ActorName, actor610);
            db.SaveChanges();

            Actor actor611 = new Actor();
            actor611.ActorName = "Christian Bale";
            db.Actors.AddOrUpdate(g => g.ActorName, actor611);
            db.SaveChanges();

            Actor actor612 = new Actor();
            actor612.ActorName = "Heath Ledger";
            db.Actors.AddOrUpdate(g => g.ActorName, actor612);
            db.SaveChanges();

            Actor actor613 = new Actor();
            actor613.ActorName = "Aaron Eckhart";
            db.Actors.AddOrUpdate(g => g.ActorName, actor613);
            db.SaveChanges();

            Actor actor614 = new Actor();
            actor614.ActorName = "Maggie Gyllenhaal";
            db.Actors.AddOrUpdate(g => g.ActorName, actor614);
            db.SaveChanges();

            Actor actor615 = new Actor();
            actor615.ActorName = "Gary Oldman";
            db.Actors.AddOrUpdate(g => g.ActorName, actor615);
            db.SaveChanges();

            Actor actor616 = new Actor();
            actor616.ActorName = "Chris Pine";
            db.Actors.AddOrUpdate(g => g.ActorName, actor616);
            db.SaveChanges();

            Actor actor617 = new Actor();
            actor617.ActorName = "Zachary Quinto";
            db.Actors.AddOrUpdate(g => g.ActorName, actor617);
            db.SaveChanges();

            Actor actor618 = new Actor();
            actor618.ActorName = "Leonard Nimoy";
            db.Actors.AddOrUpdate(g => g.ActorName, actor618);
            db.SaveChanges();

            Actor actor619 = new Actor();
            actor619.ActorName = "Eric Bana";
            db.Actors.AddOrUpdate(g => g.ActorName, actor619);
            db.SaveChanges();

            Actor actor620 = new Actor();
            actor620.ActorName = "Bruce Greenwood";
            db.Actors.AddOrUpdate(g => g.ActorName, actor620);
            db.SaveChanges();

            Actor actor621 = new Actor();
            actor621.ActorName = "Karl Urban";
            db.Actors.AddOrUpdate(g => g.ActorName, actor621);
            db.SaveChanges();

            Actor actor622 = new Actor();
            actor622.ActorName = "Jordan Nagai";
            db.Actors.AddOrUpdate(g => g.ActorName, actor622);
            db.SaveChanges();

            Actor actor623 = new Actor();
            actor623.ActorName = "Bob Peterson";
            db.Actors.AddOrUpdate(g => g.ActorName, actor623);
            db.SaveChanges();

            Actor actor624 = new Actor();
            actor624.ActorName = "Jerome Ranft";
            db.Actors.AddOrUpdate(g => g.ActorName, actor624);
            db.SaveChanges();

            Actor actor625 = new Actor();
            actor625.ActorName = "Jim Broadbent";
            db.Actors.AddOrUpdate(g => g.ActorName, actor625);
            db.SaveChanges();

            Actor actor626 = new Actor();
            actor626.ActorName = "Anika Noni Rose";
            db.Actors.AddOrUpdate(g => g.ActorName, actor626);
            db.SaveChanges();

            Actor actor627 = new Actor();
            actor627.ActorName = "Bruno Campos";
            db.Actors.AddOrUpdate(g => g.ActorName, actor627);
            db.SaveChanges();

            Actor actor628 = new Actor();
            actor628.ActorName = "Keith David";
            db.Actors.AddOrUpdate(g => g.ActorName, actor628);
            db.SaveChanges();

            Actor actor629 = new Actor();
            actor629.ActorName = "Michael-Leon Wooley";
            db.Actors.AddOrUpdate(g => g.ActorName, actor629);
            db.SaveChanges();

            Actor actor630 = new Actor();
            actor630.ActorName = "Jennifer Cody";
            db.Actors.AddOrUpdate(g => g.ActorName, actor630);
            db.SaveChanges();

            Actor actor631 = new Actor();
            actor631.ActorName = "Jim Cummings";
            db.Actors.AddOrUpdate(g => g.ActorName, actor631);
            db.SaveChanges();

            Actor actor632 = new Actor();
            actor632.ActorName = "Sam Worthington";
            db.Actors.AddOrUpdate(g => g.ActorName, actor632);
            db.SaveChanges();

            Actor actor633 = new Actor();
            actor633.ActorName = "Zoe Saldana";
            db.Actors.AddOrUpdate(g => g.ActorName, actor633);
            db.SaveChanges();

            Actor actor634 = new Actor();
            actor634.ActorName = "Stephen Lang";
            db.Actors.AddOrUpdate(g => g.ActorName, actor634);
            db.SaveChanges();

            Actor actor635 = new Actor();
            actor635.ActorName = "Michelle Rodriguez";
            db.Actors.AddOrUpdate(g => g.ActorName, actor635);
            db.SaveChanges();

            Actor actor636 = new Actor();
            actor636.ActorName = "Giovanni Ribisi";
            db.Actors.AddOrUpdate(g => g.ActorName, actor636);
            db.SaveChanges();

            Actor actor637 = new Actor();
            actor637.ActorName = "Ned Beatty";
            db.Actors.AddOrUpdate(g => g.ActorName, actor637);
            db.SaveChanges();

            Actor actor638 = new Actor();
            actor638.ActorName = "Michael Keaton";
            db.Actors.AddOrUpdate(g => g.ActorName, actor638);
            db.SaveChanges();

            Actor actor639 = new Actor();
            actor639.ActorName = "Whoopi Goldberg";
            db.Actors.AddOrUpdate(g => g.ActorName, actor639);
            db.SaveChanges();

            Actor actor640 = new Actor();
            actor640.ActorName = "Helena Bonham Carter";
            db.Actors.AddOrUpdate(g => g.ActorName, actor640);
            db.SaveChanges();

            Actor actor641 = new Actor();
            actor641.ActorName = "Guy Pearce";
            db.Actors.AddOrUpdate(g => g.ActorName, actor641);
            db.SaveChanges();

            Actor actor642 = new Actor();
            actor642.ActorName = "Timothy Spall";
            db.Actors.AddOrUpdate(g => g.ActorName, actor642);
            db.SaveChanges();

            Actor actor643 = new Actor();
            actor643.ActorName = "Michael Gambon";
            db.Actors.AddOrUpdate(g => g.ActorName, actor643);
            db.SaveChanges();

            Actor actor644 = new Actor();
            actor644.ActorName = "Jonah Hill";
            db.Actors.AddOrUpdate(g => g.ActorName, actor644);
            db.SaveChanges();

            Actor actor645 = new Actor();
            actor645.ActorName = "Chris Pratt";
            db.Actors.AddOrUpdate(g => g.ActorName, actor645);
            db.SaveChanges();

            Actor actor646 = new Actor();
            actor646.ActorName = "Stephen Bishop";
            db.Actors.AddOrUpdate(g => g.ActorName, actor646);
            db.SaveChanges();

            Actor actor647 = new Actor();
            actor647.ActorName = "Kelly Macdonald";
            db.Actors.AddOrUpdate(g => g.ActorName, actor647);
            db.SaveChanges();

            Actor actor648 = new Actor();
            actor648.ActorName = "Julie Walters";
            db.Actors.AddOrUpdate(g => g.ActorName, actor648);
            db.SaveChanges();

            Actor actor649 = new Actor();
            actor649.ActorName = "Billy Connolly";
            db.Actors.AddOrUpdate(g => g.ActorName, actor649);
            db.SaveChanges();

            Actor actor650 = new Actor();
            actor650.ActorName = "Kevin McKidd";
            db.Actors.AddOrUpdate(g => g.ActorName, actor650);
            db.SaveChanges();

            Actor actor651 = new Actor();
            actor651.ActorName = "Craig Ferguson";
            db.Actors.AddOrUpdate(g => g.ActorName, actor651);
            db.SaveChanges();

            Actor actor652 = new Actor();
            actor652.ActorName = "Anna Kendrick";
            db.Actors.AddOrUpdate(g => g.ActorName, actor652);
            db.SaveChanges();

            Actor actor653 = new Actor();
            actor653.ActorName = "Skylar Astin";
            db.Actors.AddOrUpdate(g => g.ActorName, actor653);
            db.SaveChanges();

            Actor actor654 = new Actor();
            actor654.ActorName = "Brittany Snow";
            db.Actors.AddOrUpdate(g => g.ActorName, actor654);
            db.SaveChanges();

            Actor actor655 = new Actor();
            actor655.ActorName = "Anna Camp";
            db.Actors.AddOrUpdate(g => g.ActorName, actor655);
            db.SaveChanges();

            Actor actor656 = new Actor();
            actor656.ActorName = "Rebel Wilson";
            db.Actors.AddOrUpdate(g => g.ActorName, actor656);
            db.SaveChanges();

            Actor actor657 = new Actor();
            actor657.ActorName = "Ben Platt";
            db.Actors.AddOrUpdate(g => g.ActorName, actor657);
            db.SaveChanges();

            Actor actor658 = new Actor();
            actor658.ActorName = "Elizabeth Banks";
            db.Actors.AddOrUpdate(g => g.ActorName, actor658);
            db.SaveChanges();

            Actor actor659 = new Actor();
            actor659.ActorName = "Will Arnett";
            db.Actors.AddOrUpdate(g => g.ActorName, actor659);
            db.SaveChanges();

            Actor actor660 = new Actor();
            actor660.ActorName = "Nick Offerman";
            db.Actors.AddOrUpdate(g => g.ActorName, actor660);
            db.SaveChanges();

            Actor actor661 = new Actor();
            actor661.ActorName = "Alison Brie";
            db.Actors.AddOrUpdate(g => g.ActorName, actor661);
            db.SaveChanges();

            Actor actor662 = new Actor();
            actor662.ActorName = "Dave Bautista";
            db.Actors.AddOrUpdate(g => g.ActorName, actor662);
            db.SaveChanges();

            Actor actor663 = new Actor();
            actor663.ActorName = "Vin Diesel";
            db.Actors.AddOrUpdate(g => g.ActorName, actor663);
            db.SaveChanges();

            Actor actor664 = new Actor();
            actor664.ActorName = "Bradley Cooper";
            db.Actors.AddOrUpdate(g => g.ActorName, actor664);
            db.SaveChanges();

            Actor actor665 = new Actor();
            actor665.ActorName = "Lee Pace";
            db.Actors.AddOrUpdate(g => g.ActorName, actor665);
            db.SaveChanges();

            Actor actor666 = new Actor();
            actor666.ActorName = "Mila Kunis";
            db.Actors.AddOrUpdate(g => g.ActorName, actor666);
            db.SaveChanges();

            Actor actor667 = new Actor();
            actor667.ActorName = "Kristen Bell";
            db.Actors.AddOrUpdate(g => g.ActorName, actor667);
            db.SaveChanges();

            Actor actor668 = new Actor();
            actor668.ActorName = "Kathryn Hahn";
            db.Actors.AddOrUpdate(g => g.ActorName, actor668);
            db.SaveChanges();

            Actor actor669 = new Actor();
            actor669.ActorName = "Christina Applegate";
            db.Actors.AddOrUpdate(g => g.ActorName, actor669);
            db.SaveChanges();

            Actor actor670 = new Actor();
            actor670.ActorName = "Jada Pinkett Smith";
            db.Actors.AddOrUpdate(g => g.ActorName, actor670);
            db.SaveChanges();

            Actor actor671 = new Actor();
            actor671.ActorName = "Annie Mumolo";
            db.Actors.AddOrUpdate(g => g.ActorName, actor671);
            db.SaveChanges();

        }
    }
}