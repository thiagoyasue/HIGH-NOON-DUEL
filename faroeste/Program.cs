using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faroeste
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int primeiroturno = 0;
            int escolha = -1;
            int escolha2 = -1;
            int morte = 0;
            int bala = 0;
            int bala2 = 0;
            int pers = -1;
            int tempus = 0;
            int tempus10 = 0;
            char escola = 'N';
            string[] jogador1 = { "","Atirar", "Recarregar", "Defender", "Nadinha" };
            string[] oponente = { "Xerife", "Caçador de Recompensas", "Ladrão" };
            string[] jogador2 = {"","Atirar","Recarregar","Defender", "Nada Mesmo"};
            int menu = 0;
            Console.WriteLine("\n\n\n\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                                   ,wgg&&&gw,,                                 ");
            Console.WriteLine("                               ,g$lllllllllllll@w                            ");
            Console.WriteLine("                             /$llllll&M***M&llllll%,                         ");
            Console.WriteLine("                           ,$llll$'           `*lllllg                        ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("                           $llll'                Y %%%%");
            Console.WriteLine("                          $llllF      g$$,                                     ");
            Console.WriteLine("                          lllll     g$llll$w                                   ");
            Console.WriteLine("                          lllll     `YllllF                                    ");
            Console.WriteLine("                          ]llllk       **                                      ");
            Console.WriteLine("                           %llllg,             ,$llllF                          ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                            1$$$$$@w,       ,g@$$$$@`                           ");
            Console.WriteLine("                              %$$$$$$$$@@$$$$$$$$@'                             ");
            Console.WriteLine("                                *%$$$$$$$$$$$% *");
            Console.WriteLine("                                     `'''''                                     ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                              CHEKPOINT GAME STUDIO");
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("\n\n\n\n");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                                   ,wgg&&&gw,,                                 ");
            Console.WriteLine("                               ,g$lllllllllllll@w                            ");
            Console.WriteLine("                             /$llllll&M***M&llllll%,                         ");
            Console.WriteLine("                           ,$llll$'           `*lllllg                        ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                           $llll'                Y %%%%");
            Console.WriteLine("                          $llllF      g$$,                                     ");
            Console.WriteLine("                          lllll     g$llll$w                                   ");
            Console.WriteLine("                          lllll     `YllllF                                    ");
            Console.WriteLine("                          ]llllk       **                                      ");
            Console.WriteLine("                           %llllg,             ,$llllF                          ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                            1$$$$$@w,       ,g@$$$$@`                           ");
            Console.WriteLine("                              %$$$$$$$$@@$$$$$$$$@'                             ");
            Console.WriteLine("                                *%$$$$$$$$$$$% *");
            Console.WriteLine("                                     `'''''                                     ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                                 CHECKPOINT EAST");
            Console.WriteLine("                             a Checkpoint Coproducer Studio");
            Console.WriteLine("                                    presents...");
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
            do
            {
                Console.Clear();
                morte = 0;
                a = 0;
                bala = 0;
                bala2 = 0;
                tempus = 0;
                tempus10 = 0;
                primeiroturno = 0;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("ooooo   ooooo  o8o             oooo             ooooo      ooo                                   ");
                Console.WriteLine("`888'   `888'  `''             `888             `888b.     `8'                                    ");
                Console.WriteLine(" 888     888  oooo   .oooooooo  888 .oo.         8 `88b.    8   .ooooo.   .ooooo.  ooo. .oo.    ");
                Console.WriteLine(" 888ooooo888  `888  888' `88b   888P'Y88b        8   `88b.  8  d88' `88b d88' `88b `888P'Y88b   ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" 888     888   888  888   888   888   888        8     `88b.8  888   888 888   888  888   888    ");
                Console.WriteLine(" 888     888   888  `88bod8P'   888   888        8       `888  888   888 888   888  888   888    ");
                Console.WriteLine("o888o   o888o o888o `8oooooo.  o888o o888o      o8o        `8  `Y8bod8P' `Y8bod8P' o888o o888o   ");
                Console.WriteLine("                    d'     YD                                                                    ");
                Console.WriteLine("                    'Y88888P'                                                                    ");
                Console.WriteLine("");
                Console.WriteLine("                                   oooooooooo.                         oooo                      ");
                Console.WriteLine("                                   `888'   `Y8b                        `888                      ");
                Console.WriteLine("                                    888      888 oooo  oooo   .ooooo.   888                      ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("                                    888      888 `888  `888  d88' `88b  888                       ");
                Console.WriteLine("                                    888      888  888   888  888ooo888  888                        ");
                Console.WriteLine("                                    888     d88'  888   888  888    .o  888                        ");
                Console.WriteLine("                                   o888bood8P'    `V88V'V8P' `Y8bod8P' o888o                       ");
                Console.WriteLine("");
                Console.WriteLine("                              Mostre a eles quem manda na cidade de Silverneck\n");
                Console.WriteLine("                                       Checkpoint East - 2019\n\n");
                Console.WriteLine("                         (1) Jogar História");
                Console.WriteLine("                         (2) Jogar 1x1");
                Console.WriteLine("                         (3) Instruções");
                Console.WriteLine("                         (4) Sair");

                menu = int.Parse(Console.ReadLine());
                //seleção de tela
                switch (menu)
                {
                    case 1:
                        do
                        {
                            //escolha de personagens
                            Console.Clear();
                            Console.WriteLine("Escolha seu Personagem:");
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("(1) Xerife");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("(2) Caçador de Recompensas");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("(3) Ladrão");
                            pers = int.Parse(Console.ReadLine());
                            if (pers == 1)
                            {
                                Console.WriteLine("Descrição:\nO Xerife está a procura do Esqueleto, um bandido morto-vivo que roubou o Diamante de Silverneck.");
                                Console.WriteLine("Confirmar escolha?     Y/N");
                                escola = char.Parse(Console.ReadLine());
                            }
                            else if(pers == 2)
                            {
                                Console.WriteLine("Descrição:\nO Caçador de Recompensas está atrás da cabeça do Ladrão, que certamente lhe garantirá uma boa quantia de dinheiro.");
                                Console.WriteLine("Confirmar escolha?     Y/N");
                                escola = char.Parse(Console.ReadLine());
                            }
                            else if(pers == 3)
                            {
                                Console.WriteLine("Descrição:\nO Ladrão está a procura de dinheiro no Banco de Silverneck.");
                                Console.WriteLine("Confirmar escolha?     Y/N");
                                escola = char.Parse(Console.ReadLine());
                            }
                            if (escola == 'y')
                                escola = 'Y';
                        }
                        while (escola != 'Y');
                        Console.Clear();
                        if (pers == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Dia 1, Delegacia, 11:58");
                            Console.WriteLine("[Caçador de Recompensas] Xerife... Você me prometeu uma recompensa e não cumpriu com o combinado.");
                            Console.WriteLine("[Xerife] Eu já te disse. O Esqueleto roubou o diamante da cidade. Aquele diamante era a recompensa.");
                            Console.WriteLine("        `.hs+                                                                            shd..       ");
                            Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                            Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                            Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                            Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                            Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                            Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                            Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                            Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                            Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                            Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                            Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                            Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                            Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                            Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                            Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                            Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                            Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Dia 1, Delegacia, 11:59");
                            Console.WriteLine("[Caçador de Recompensas] Não importa. Se eu não vou ter a minha recompensa, eu quero a sua cabeça como troféu");
                            Console.WriteLine("        `.hs+                                                                            shd..       ");
                            Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                            Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                            Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                            Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                            Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                            Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                            Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                            Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                            Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                            Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                            Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                            Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                            Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                            Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                            Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                            Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                            Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                            Console.ReadKey();
                            Console.Clear();
                            do
                            {
                                Console.WriteLine("Dia 1, Delegacia, 12:{0}{1}",tempus10,tempus);
                                Console.WriteLine("É meio dia.");
                                Console.WriteLine("        `.hs+                                                                            shd..       ");
                                Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                Console.WriteLine("Xerife, faça a sua decisão: (1)Atirar  (2)Recarregar  (3)Esquivar");
                                escolha = int.Parse(Console.ReadLine());
                                Console.Clear();
                                //bala = munição
                                //escolha = escolhas do jogador
                                //escolha = 1: atirar
                                //escolha = 2: recarregar
                                //escolha = 3: esquivar
                                if (escolha == 1)
                                {
                                    Console.WriteLine("Xerife sacou o seu revólver...");
                                    if (bala < 1)
                                    {
                                        Console.WriteLine("Mas estava sem balas!");
                                        escolha = 4;
                                    }
                                    else
                                    {
                                        Console.WriteLine("E apertou o gatilho!");
                                        bala--;
                                    }
                                }
                                else if (escolha == 2)
                                {
                                    Console.WriteLine("Xerife decidiu colocar uma bala em seu revólver...");
                                    bala++;
                                }
                                else if (escolha == 3)
                                {
                                    Console.WriteLine("Xerife decidiu se esquivar para escapar do tiro...");
                                }

                                Random rand = new Random();

                                //inteligencia artificial da máquina
                                //bala = munição
                                //escolha2 = escolhas da IA
                                //escolha2 = 1: atirar
                                //escolha2 = 2: recarregar
                                //escolha2 = 3: esquivar

                                if (primeiroturno == 0)
                                {
                                    Console.WriteLine("Caçador de Recompensas decidiu colocar uma bala em seu revólver...");
                                    bala2++;
                                    primeiroturno = 1;
                                    escolha2 = 2;
                                }
                                else
                                {
                                    if (bala2 > 0)
                                    {
                                        if (bala > 0)
                                        {
                                            int auxescolha;
                                            auxescolha = rand.Next(1, 3);
                                            if (auxescolha == 1)
                                            {
                                                escolha2 = 1;
                                            }
                                            else
                                                escolha2 = 3;

                                        }
                                        else
                                        {
                                            escolha2 = 1;
                                        }
                                    }
                                    else
                                    {
                                        escolha2 = rand.Next(2, 4);
                                    }

                                    if (escolha2 == 1)
                                    {
                                        Console.WriteLine("Caçador de Recompensas sacou o seu revólver...");
                                        if (bala2 < 1)
                                        {
                                            Console.WriteLine("Mas estava sem balas!");
                                            escolha2 = 4;
                                        }
                                        else
                                        {
                                            Console.WriteLine("E apertou o gatilho!");
                                            bala2--;
                                        }
                                    }
                                    else if (escolha2 == 2)
                                    {
                                        Console.WriteLine("Caçador de Recompensas decidiu colocar uma bala em seu revólver...");
                                        bala2++;
                                    }
                                    else if (escolha2 == 3)
                                    {
                                        Console.WriteLine("Caçador de Recompensas decidiu se esquivar para escapar do tiro...");
                                    }

                                }

                                if (escolha == 1 && escolha2 == 1)
                                {
                                    Console.WriteLine("       ..dhs                                                                            shd..       ");
                                    Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                    Console.WriteLine("     -osNMMd/..```    ```                                                  ```    ```../dMMNso-     ");
                                    Console.WriteLine("    .mMMMMMNddmmdhyyhyms/-:-                                            -:-/smyhyyhdmmddNMMMMMm.    ");
                                    Console.WriteLine("    hNNMMMMo   ````..::                                                      ::..````   oMMMMNNh    ");
                                    Console.WriteLine("   :NsdMMMM/                                                                            /MMMMdsN:   ");
                                    Console.WriteLine("   hm`dMMMMs                                                                            sMMMMd`mh   ");
                                    Console.WriteLine("  :No-NMMMMh                                                                            hMMMMN-oN:  ");
                                    Console.WriteLine("  /N/NMMmMMm-                                                                          -mMMmMMN/N/ ");
                                    Console.WriteLine("  syyMMd.NMM:                                                                          :MMN.dMMyys  ");
                                    Console.WriteLine("  s`sMN: sMm`                                                                          `mMs :NMs`s  ");
                                    Console.WriteLine("  . dMs  -MN`                                                                          `NM-  sMd .  ");
                                    Console.WriteLine("   /MN`  `NM-                                                                          -MN`  `NM/  ");
                                    Console.WriteLine("   mM+    hMo                                                                          oMh    +Mm  ");
                                    Console.WriteLine("  oMd     .Nd                                                                          dN.     dMo  ");
                                    Console.WriteLine("`oNN/.`    hNyo:`                                                                  `:oyNh    `./NNo`");
                                    Console.WriteLine(" .-yydmhsooydMMNmmmmhssso+++:-                                        -:+++ossshmmmmNMMdyooshmdyy-. ");
                                    Console.WriteLine("     `:ydNMMMMMMMMMMdo----:::-                                        -:::----odMMMMMMMMMMNdy:`     ");
                                    Console.WriteLine("         `...../ooo+:`                                                        `:+ooo/.....`         ");
                                    Console.WriteLine("Os dois caubóis atiram ao mesmo tempo! Cada bala ricocheteia a outra, que explodem no ar!");

                                }
                                if (escolha == 1 && escolha2 == 2 || escolha == 1 && escolha2 == 4)
                                {

                                    morte = 1;
                                    a = 1;

                                    Console.WriteLine("        ..dhs                                                                                        ");
                                    Console.WriteLine("       `dMMm-`                                                                                      ");
                                    Console.WriteLine("     -osNMMd/..```    ```                                                                           ");
                                    Console.WriteLine("    .mMMMMMNddmmdhyyhyms/-:-                                          `                 .           ");
                                    Console.WriteLine("   hNNMMMMo   ````..::                                              +h/       .-.     -h-          ");
                                    Console.WriteLine("   :NsdMMMM/                                                         `dd-    ` dMN-    ymh`         ");
                                    Console.WriteLine("   hm`dMMMMs                                                          `ydyyhhhyNMm-   `:``          ");
                                    Console.WriteLine("  :No-NMMMMh                                                            .:yMMMMMMNh.                ");
                                    Console.WriteLine("  /N/NMMmMMm-                                                          .+mMMMMMNdmMy`               ");
                                    Console.WriteLine("  syyMMd.NMM:                                                         :mMMMMms:-`.hMy:--.+:-        ");
                                    Console.WriteLine("  s`sMN: sMm`                                                       `+NMMMm+`     `+shhhoss:        ");
                                    Console.WriteLine("  . dMs  -MN`                                                       sMMMm+.           ``            ");
                                    Console.WriteLine("   /MN`  `NM-                                                       dMNdmmho-                       ");
                                    Console.WriteLine("   mM+    hMo                                                       -hNmo:+hmh.                     ");
                                    Console.WriteLine("  oMd     .Nd                                                        `:yNd-.ms                      ");
                                    Console.WriteLine("`oNN/.`    hNyo:`                                                      `/Nh`.  ``   .-.             ");
                                    Console.WriteLine(" .-yydmhsooydMMNmmmmhssso+++:-                                         `+hdhsyhmNdhsdNNmh:    .::-` ");
                                    Console.WriteLine("     `:ydNMMMMMMMMMMdo----:::-                                           ``./oyddmNMMMMMMNy/. `omNd`");
                                    Console.WriteLine("         `...../ooo+:`                                                           ``.+hMMMMMNd   `:+.");
                                    Console.WriteLine("                                                                                   /yss+//.         ");


                                    Console.WriteLine("O Xerife atira mais rápido, acertando em cheio o Caçador de Recompensas");

                                }
                                if (escolha == 1 && escolha2 == 3)
                                {

                                    Console.WriteLine("        `.hs+                                                                            shd..       ");
                                    Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                    Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                    Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                    Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                    Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                    Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                    Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                    Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                    Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                    Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                    Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                    Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                    Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                    Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                    Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                    Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                    Console.WriteLine("O Xerife efetua o disparo, mas o Caçador de Recompensas rapidamente se esquiva!");
                                }
                                if (escolha == 2 && escolha2 == 2)
                                {
                                    Console.WriteLine("        `.hs+                                                                            shd..       ");
                                    Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                    Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                    Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                    Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                    Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                    Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                    Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                    Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                    Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                    Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                    Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                    Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                    Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                    Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                    Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                    Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                    Console.WriteLine("Os dois caubóis decidem recarregar ao mesmo tempo!");
                                }


                                if (escolha == 2 && escolha2 == 1 || escolha == 4 && escolha2 == 1)
                                {
                                    Console.WriteLine("                                                                                         shd..");
                                    Console.WriteLine("                                                                                      `-mMMd` ");
                                    Console.WriteLine("                                                                           ```    ```../dMMNso- ");
                                    Console.WriteLine("           .                 `                                          -:-/smyhyyhdmmddNMMMMMm. ");
                                    Console.WriteLine("          -h-     .-.       /h+                                              ::..````   oMMMMNNh   ");
                                    Console.WriteLine("         `hmy    -NMd `    -dd`                                                         /MMMMdsN:   ");
                                    Console.WriteLine("          ``:`   -mMNyhhhyydy`                                                          sMMMMd`mh   ");
                                    Console.WriteLine("                .hNMMMMMMy:.                                                            hMMMMN-oN:  ");
                                    Console.WriteLine("               `yMmdNMMMMMm+.                                                          -mMMmMMN/N/  ");
                                    Console.WriteLine("        -:+.--:yMh.`-:smMMMMm:                                                         :MMN.dMMyys  ");
                                    Console.WriteLine("        :ssohhhs+`     `+mMMMN+`                                                       `mMs :NMs`s  ");
                                    Console.WriteLine("            ``           .+mMMMs                                                       `NM-  sMd .  ");
                                    Console.WriteLine("                       -ohmmdNMd                                                       -MN`  `NM/   ");
                                    Console.WriteLine("                     .hmh+:omNh-                                                       oMh    +Mm   ");
                                    Console.WriteLine("                      sm.-dNy:`                                                        dN.     dMo  ");
                                    Console.WriteLine("             .-.   ``  .`hN/`                                                      `:oyNh    `./NNo`");
                                    Console.WriteLine(" `-::.    :hmNNdshdNmhyshdh+`                                         -:+++ossshmmmmNMMdyooshmdyy-. ");
                                    Console.WriteLine("`dNmo` ./yNMMMMMMNmddyo/.``                                           -:::----odMMMMMMMMMMNdy:`     ");
                                    Console.WriteLine(".+:`   dNMMMMMh+.``                                                           `:+ooo/.....`         ");
                                    Console.WriteLine("         .//+ssy/                                                                                   ");

                                    morte = 1;
                                    a = 2;

                                    Console.WriteLine("O Caçador de Recompensas atira mais rápido, acertando em cheio o Xerife!");
                                }
                                if (escolha == 3 && escolha2 == 1)
                                {
                                    Console.WriteLine("        `.hs+                                                                            shd..       ");
                                    Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                    Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                    Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                    Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                    Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                    Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                    Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                    Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                    Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                    Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                    Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                    Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                    Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                    Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                    Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                    Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                    Console.WriteLine("O Caçador de Recompensas efetua o disparo, mas o Xerife rapidamente se esquiva!");

                                }

                                if (escolha == 3 && escolha2 == 3)
                                {
                                    Console.WriteLine("        `.hs+                                                                            shd..       ");
                                    Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                    Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                    Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                    Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                    Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                    Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                    Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                    Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                    Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                    Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                    Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                    Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                    Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                    Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                    Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                    Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                    Console.WriteLine("Os dois caubóis escolhem se esquivar e ninguém atira!");
                                }

                                if (escolha == 3 && escolha2 == 2 || escolha == 2 && escolha2 == 3 || escolha == 4 && escolha2 == 4 || escolha == 3 && escolha2 == 4 || escolha == 4 && escolha2 == 3 || escolha == 2 && escolha2 == 4 || escolha == 4 && escolha2 == 2)
                                {
                                    Console.WriteLine("        `.hs+                                                                            shd..       ");
                                    Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                    Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                    Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                    Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                    Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                    Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                    Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                    Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                    Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                    Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                    Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                    Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                    Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                    Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                    Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                    Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                    Console.WriteLine("Ninguém decide atacar neste turno!");
                                }

                                Console.ReadKey();
                                Console.Clear();
                                //temporizador: a cada turno, acrescenta-se 1 minuto dentro do jogo. 
                                //Se o horário for maior que 12:59, perde-se o jogo.
                                tempus++;
                                if (tempus >= 10)
                                {
                                    tempus = 0;
                                    tempus10++;
                                }
                                if (tempus10 == 6)
                                {
                                    a = 3;
                                    morte = 1;
                                }
                            }
                            while (morte != 1);
                            if (a == 1)
                            {
                                // PARTE 2 HISTÓRIA DO XERIFE
                                morte = 0;
                                a = 0;
                                bala = 0;
                                bala2 = 0;
                                primeiroturno = 0;

                                Console.WriteLine("Dia 1, Delegacia, 12:{0}{1}", tempus10,tempus);
                                Console.WriteLine("[Xerife] ...");
                                Console.WriteLine("[Xerife] Preciso ir atrás daquele esqueleto pra acabar logo com isso");
                                Console.WriteLine("        ..dhs                                                                                        ");
                                Console.WriteLine("       `dMMm-`                                                                                      ");
                                Console.WriteLine("     -osNMMd/..```    ```                                                                           ");
                                Console.WriteLine("    .mMMMMMNddmmdhyyhyms/-:-                                          `                 .           ");
                                Console.WriteLine("   hNNMMMMo   ````..::                                              +h/       .-.     -h-          ");
                                Console.WriteLine("   :NsdMMMM/                                                         `dd-    ` dMN-    ymh`         ");
                                Console.WriteLine("   hm`dMMMMs                                                          `ydyyhhhyNMm-   `:``          ");
                                Console.WriteLine("  :No-NMMMMh                                                            .:yMMMMMMNh.                ");
                                Console.WriteLine("  /N/NMMmMMm-                                                          .+mMMMMMNdmMy`               ");
                                Console.WriteLine("  syyMMd.NMM:                                                         :mMMMMms:-`.hMy:--.+:-        ");
                                Console.WriteLine("  s`sMN: sMm`                                                       `+NMMMm+`     `+shhhoss:        ");
                                Console.WriteLine("  . dMs  -MN`                                                       sMMMm+.           ``            ");
                                Console.WriteLine("   /MN`  `NM-                                                       dMNdmmho-                       ");
                                Console.WriteLine("   mM+    hMo                                                       -hNmo:+hmh.                     ");
                                Console.WriteLine("  oMd     .Nd                                                        `:yNd-.ms                      ");
                                Console.WriteLine("`oNN/.`    hNyo:`                                                      `/Nh`.  ``   .-.             ");
                                Console.WriteLine(" .-yydmhsooydMMNmmmmhssso+++:-                                         `+hdhsyhmNdhsdNNmh:    .::-` ");
                                Console.WriteLine("     `:ydNMMMMMMMMMMdo----:::-                                           ``./oyddmNMMMMMMNy/. `omNd`");
                                Console.WriteLine("         `...../ooo+:`                                                           ``.+hMMMMMNd   `:+.");
                                Console.WriteLine("                                                                                   /yss+//.         ");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("Dia 2, Casarão Abandonado, 11:58");
                                Console.WriteLine("[Xerife] Quem está aí!");
                                Console.WriteLine("[Ladrão] Parece que você me achou, Xerife! Mas como você está vendo, não estou roubando nada!");
                                Console.WriteLine("        `.hs+                                                                            shd..       ");
                                Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("Dia 2, Casarão Abandonado, 11:59");
                                Console.WriteLine("[Xerife] Você sabe onde o Esqueleto está?");
                                Console.WriteLine("[Ladrão] Ora ora... O Xerife pedindo ajuda pra um bandido. Te ajudo em troca da minha liberdade...");
                                Console.WriteLine("[Xerife] Então eu acho que eu vou ter que procurar o Esqueleto sozinho...");
                                Console.WriteLine("        `.hs+                                                                            shd..       ");
                                Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                Console.ReadKey();
                                Console.Clear();
                                tempus = 0;
                                tempus10 = 0;
                                do
                                {
                                    Console.WriteLine("Dia 2, Casarão Abandonado, 12:{0}{1}", tempus10,tempus);
                                    Console.WriteLine("É meio dia.");
                                    Console.WriteLine("        `.hs+                                                                            shd..       ");
                                    Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                    Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                    Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                    Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                    Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                    Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                    Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                    Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                    Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                    Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                    Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                    Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                    Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                    Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                    Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                    Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                    Console.WriteLine("Xerife, faça a sua decisão: (1)Atirar  (2)Recarregar  (3)Esquivar");
                                    escolha = int.Parse(Console.ReadLine());
                                    Console.Clear();



                                    if (escolha == 1)
                                    {
                                        Console.WriteLine("Xerife sacou o seu revólver...");
                                        if (bala < 1)
                                        {
                                            Console.WriteLine("Mas estava sem balas!");
                                            escolha = 4;
                                        }
                                        else
                                        {
                                            Console.WriteLine("E apertou o gatilho!");
                                            bala++;
                                        }
                                    }
                                    else if (escolha == 2)
                                    {
                                        Console.WriteLine("Xerife decidiu colocar uma bala em seu revólver...");
                                        bala++;
                                    }
                                    else if (escolha == 3)
                                    {
                                        Console.WriteLine("Xerife decidiu se esquivar para escapar do tiro...");
                                    }

                                    Random rand = new Random();
                                    escolha2 = rand.Next(1, 3);
                                    if (primeiroturno == 0)
                                    {
                                        Console.WriteLine("Caçador de Recompensas decidiu colocar uma bala em seu revólver...");
                                        bala2++;
                                        primeiroturno = 1;
                                        escolha2 = 2;
                                    }
                                    else
                                    {
                                        if (escolha2 == 1)
                                        {
                                            Console.WriteLine("Caçador de Recompensas sacou o seu revólver...");
                                            if (bala2 < 1)
                                            {
                                                Console.WriteLine("Mas estava sem balas!");
                                                escolha2 = 4;
                                            }
                                            else
                                            {
                                                Console.WriteLine("E apertou o gatilho!");
                                                bala2--;
                                            }
                                        }
                                        else if (escolha2 == 2)
                                        {
                                            Console.WriteLine("Caçador de Recompensas decidiu colocar uma bala em seu revólver...");
                                            bala2++;
                                        }
                                        else if (escolha2 == 3)
                                        {
                                            Console.WriteLine("Caçador de Recompensas decidiu se esquivar para escapar do tiro...");
                                        }


                                    }
                                    if (escolha == 1 && escolha2 == 1)
                                    {
                                        Console.WriteLine("       ..dhs                                                                            shd..       ");
                                        Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                        Console.WriteLine("     -osNMMd/..```    ```                                                  ```    ```../dMMNso-     ");
                                        Console.WriteLine("    .mMMMMMNddmmdhyyhyms/-:-                                            -:-/smyhyyhdmmddNMMMMMm.    ");
                                        Console.WriteLine("    hNNMMMMo   ````..::                                                      ::..````   oMMMMNNh    ");
                                        Console.WriteLine("   :NsdMMMM/                                                                            /MMMMdsN:   ");
                                        Console.WriteLine("   hm`dMMMMs                                                                            sMMMMd`mh   ");
                                        Console.WriteLine("  :No-NMMMMh                                                                            hMMMMN-oN:  ");
                                        Console.WriteLine("  /N/NMMmMMm-                                                                          -mMMmMMN/N/ ");
                                        Console.WriteLine("  syyMMd.NMM:                                                                          :MMN.dMMyys  ");
                                        Console.WriteLine("  s`sMN: sMm`                                                                          `mMs :NMs`s  ");
                                        Console.WriteLine("  . dMs  -MN`                                                                          `NM-  sMd .  ");
                                        Console.WriteLine("   /MN`  `NM-                                                                          -MN`  `NM/  ");
                                        Console.WriteLine("   mM+    hMo                                                                          oMh    +Mm  ");
                                        Console.WriteLine("  oMd     .Nd                                                                          dN.     dMo  ");
                                        Console.WriteLine("`oNN/.`    hNyo:`                                                                  `:oyNh    `./NNo`");
                                        Console.WriteLine(" .-yydmhsooydMMNmmmmhssso+++:-                                        -:+++ossshmmmmNMMdyooshmdyy-. ");
                                        Console.WriteLine("     `:ydNMMMMMMMMMMdo----:::-                                        -:::----odMMMMMMMMMMNdy:`     ");
                                        Console.WriteLine("         `...../ooo+:`                                                        `:+ooo/.....`         ");
                                        Console.WriteLine("Os dois caubóis atiram ao mesmo tempo! Cada bala ricocheteia a outra, que explodem no ar!");

                                    }
                                    if (escolha == 1 && escolha2 == 2 || escolha == 1 && escolha2 == 4)
                                    {

                                        morte = 1;
                                        a = 1;

                                        Console.WriteLine("        ..dhs                                                                                        ");
                                        Console.WriteLine("       `dMMm-`                                                                                      ");
                                        Console.WriteLine("     -osNMMd/..```    ```                                                                           ");
                                        Console.WriteLine("    .mMMMMMNddmmdhyyhyms/-:-                                          `                 .           ");
                                        Console.WriteLine("   hNNMMMMo   ````..::                                              +h/       .-.     -h-          ");
                                        Console.WriteLine("   :NsdMMMM/                                                         `dd-    ` dMN-    ymh`         ");
                                        Console.WriteLine("   hm`dMMMMs                                                          `ydyyhhhyNMm-   `:``          ");
                                        Console.WriteLine("  :No-NMMMMh                                                            .:yMMMMMMNh.                ");
                                        Console.WriteLine("  /N/NMMmMMm-                                                          .+mMMMMMNdmMy`               ");
                                        Console.WriteLine("  syyMMd.NMM:                                                         :mMMMMms:-`.hMy:--.+:-        ");
                                        Console.WriteLine("  s`sMN: sMm`                                                       `+NMMMm+`     `+shhhoss:        ");
                                        Console.WriteLine("  . dMs  -MN`                                                       sMMMm+.           ``            ");
                                        Console.WriteLine("   /MN`  `NM-                                                       dMNdmmho-                       ");
                                        Console.WriteLine("   mM+    hMo                                                       -hNmo:+hmh.                     ");
                                        Console.WriteLine("  oMd     .Nd                                                        `:yNd-.ms                      ");
                                        Console.WriteLine("`oNN/.`    hNyo:`                                                      `/Nh`.  ``   .-.             ");
                                        Console.WriteLine(" .-yydmhsooydMMNmmmmhssso+++:-                                         `+hdhsyhmNdhsdNNmh:    .::-` ");
                                        Console.WriteLine("     `:ydNMMMMMMMMMMdo----:::-                                           ``./oyddmNMMMMMMNy/. `omNd`");
                                        Console.WriteLine("         `...../ooo+:`                                                           ``.+hMMMMMNd   `:+.");
                                        Console.WriteLine("                                                                                   /yss+//.         ");


                                        Console.WriteLine("O Xerife atira mais rápido, acertando em cheio o Caçador de Recompensas");

                                    }
                                    if (escolha == 1 && escolha2 == 3)
                                    {

                                        Console.WriteLine("        `.hs+                                                                            shd..       ");
                                        Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                        Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                        Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                        Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                        Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                        Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                        Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                        Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                        Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                        Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                        Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                        Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                        Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                        Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                        Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                        Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                        Console.WriteLine("O Xerife efetua o disparo, mas o Caçador de Recompensas rapidamente se esquiva!");
                                    }
                                    if (escolha == 2 && escolha2 == 2)
                                    {
                                        Console.WriteLine("        `.hs+                                                                            shd..       ");
                                        Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                        Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                        Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                        Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                        Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                        Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                        Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                        Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                        Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                        Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                        Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                        Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                        Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                        Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                        Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                        Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                        Console.WriteLine("Os dois caubóis decidem recarregar ao mesmo tempo!");
                                    }


                                    if (escolha == 2 && escolha2 == 1 || escolha == 4 && escolha2 == 1)
                                    {
                                        Console.WriteLine("                                                                                         shd..");
                                        Console.WriteLine("                                                                                      `-mMMd` ");
                                        Console.WriteLine("                                                                           ```    ```../dMMNso- ");
                                        Console.WriteLine("           .                 `                                          -:-/smyhyyhdmmddNMMMMMm. ");
                                        Console.WriteLine("          -h-     .-.       /h+                                              ::..````   oMMMMNNh   ");
                                        Console.WriteLine("         `hmy    -NMd `    -dd`                                                         /MMMMdsN:   ");
                                        Console.WriteLine("          ``:`   -mMNyhhhyydy`                                                          sMMMMd`mh   ");
                                        Console.WriteLine("                .hNMMMMMMy:.                                                            hMMMMN-oN:  ");
                                        Console.WriteLine("               `yMmdNMMMMMm+.                                                          -mMMmMMN/N/  ");
                                        Console.WriteLine("        -:+.--:yMh.`-:smMMMMm:                                                         :MMN.dMMyys  ");
                                        Console.WriteLine("        :ssohhhs+`     `+mMMMN+`                                                       `mMs :NMs`s  ");
                                        Console.WriteLine("            ``           .+mMMMs                                                       `NM-  sMd .  ");
                                        Console.WriteLine("                       -ohmmdNMd                                                       -MN`  `NM/   ");
                                        Console.WriteLine("                     .hmh+:omNh-                                                       oMh    +Mm   ");
                                        Console.WriteLine("                      sm.-dNy:`                                                        dN.     dMo  ");
                                        Console.WriteLine("             .-.   ``  .`hN/`                                                      `:oyNh    `./NNo`");
                                        Console.WriteLine(" `-::.    :hmNNdshdNmhyshdh+`                                         -:+++ossshmmmmNMMdyooshmdyy-. ");
                                        Console.WriteLine("`dNmo` ./yNMMMMMMNmddyo/.``                                           -:::----odMMMMMMMMMMNdy:`     ");
                                        Console.WriteLine(".+:`   dNMMMMMh+.``                                                           `:+ooo/.....`         ");
                                        Console.WriteLine("         .//+ssy/                                                                                   ");
                                        morte = 1;
                                        a = 2;

                                        Console.WriteLine("O Caçador de Recompensas atira mais rápido, acertando em cheio o Xerife!");
                                    }
                                    if (escolha == 3 && escolha2 == 1)
                                    {
                                        Console.WriteLine("        `.hs+                                                                            shd..       ");
                                        Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                        Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                        Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                        Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                        Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                        Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                        Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                        Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                        Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                        Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                        Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                        Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                        Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                        Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                        Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                        Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                        Console.WriteLine("O Caçador de Recompensas efetua o disparo, mas o Xerife rapidamente se esquiva!");

                                    }

                                    if (escolha == 3 && escolha2 == 3)
                                    {
                                        Console.WriteLine("        `.hs+                                                                            shd..       ");
                                        Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                        Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                        Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                        Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                        Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                        Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                        Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                        Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                        Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                        Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                        Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                        Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                        Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                        Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                        Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                        Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                        Console.WriteLine("Os dois caubóis escolhem se esquivar e ninguém atira!");
                                    }

                                    if (escolha == 3 && escolha2 == 2 || escolha == 2 && escolha2 == 3 || escolha == 4 && escolha2 == 4 || escolha == 3 && escolha2 == 4 || escolha == 4 && escolha2 == 3 || escolha == 2 && escolha2 == 4 || escolha == 4 && escolha2 == 2)
                                    {
                                        Console.WriteLine("        `.hs+                                                                            shd..       ");
                                        Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                        Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                        Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                        Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                        Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                        Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                        Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                        Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                        Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                        Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                        Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                        Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                        Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                        Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                        Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                        Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                        Console.WriteLine("Ninguém decide atacar neste turno!");
                                    }

                                    Console.ReadKey();
                                    Console.Clear();
                                    tempus++;
                                    if (tempus >= 10)
                                    {
                                        tempus = 0;
                                        tempus10++;
                                    }
                                    if (tempus10 == 6)
                                    {
                                        a = 3;
                                        morte = 1;
                                    }
                                }
                                while (morte != 1);
                                if (a == 1)
                                {
                                    //PARTE 3 HISTÓRIA DO XERIFE

                                    morte = 0;
                                    a = 0;
                                    bala = 0;
                                    bala2 = 0;
                                    primeiroturno = 0;
                                    Console.WriteLine("Dia 2, Casarão Abandonado, 12:{0}{1}", tempus10,tempus);
                                    Console.WriteLine("[Xerife] Estou perdendo tempo demais com esses idiotas. Preciso me focar em procurar o Esqueleto.");
                                    Console.WriteLine("        ..dhs                                                                                        ");
                                    Console.WriteLine("       `dMMm-`                                                                                      ");
                                    Console.WriteLine("     -osNMMd/..```    ```                                                                           ");
                                    Console.WriteLine("    .mMMMMMNddmmdhyyhyms/-:-                                          `                 .           ");
                                    Console.WriteLine("   hNNMMMMo   ````..::                                              +h/       .-.     -h-          ");
                                    Console.WriteLine("   :NsdMMMM/                                                         `dd-    ` dMN-    ymh`         ");
                                    Console.WriteLine("   hm`dMMMMs                                                          `ydyyhhhyNMm-   `:``          ");
                                    Console.WriteLine("  :No-NMMMMh                                                            .:yMMMMMMNh.                ");
                                    Console.WriteLine("  /N/NMMmMMm-                                                          .+mMMMMMNdmMy`               ");
                                    Console.WriteLine("  syyMMd.NMM:                                                         :mMMMMms:-`.hMy:--.+:-        ");
                                    Console.WriteLine("  s`sMN: sMm`                                                       `+NMMMm+`     `+shhhoss:        ");
                                    Console.WriteLine("  . dMs  -MN`                                                       sMMMm+.           ``            ");
                                    Console.WriteLine("   /MN`  `NM-                                                       dMNdmmho-                       ");
                                    Console.WriteLine("   mM+    hMo                                                       -hNmo:+hmh.                     ");
                                    Console.WriteLine("  oMd     .Nd                                                        `:yNd-.ms                      ");
                                    Console.WriteLine("`oNN/.`    hNyo:`                                                      `/Nh`.  ``   .-.             ");
                                    Console.WriteLine(" .-yydmhsooydMMNmmmmhssso+++:-                                         `+hdhsyhmNdhsdNNmh:    .::-` ");
                                    Console.WriteLine("     `:ydNMMMMMMMMMMdo----:::-                                           ``./oyddmNMMMMMMNy/. `omNd`");
                                    Console.WriteLine("         `...../ooo+:`                                                           ``.+hMMMMMNd   `:+.");
                                    Console.WriteLine("                                                                                   /yss+//.         ");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("Dia 3, Trem do Meio-dia, 11:58");
                                    Console.WriteLine("[Xerife] Parado, Esqueleto! Você está preso por roubar o diamante de Silverneck!");
                                    Console.WriteLine("        `.hs+                                                                            shd..       ");
                                    Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                    Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                    Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                    Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                    Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                    Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                    Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                    Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                    Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                    Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                    Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                    Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                    Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                    Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                    Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                    Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("Dia 3, Trem do Meio dia, 11:59");
                                    Console.WriteLine("[Esqueleto] Esse Diamante vai me trazer à vida e me concederá poderes ilimitados. É uma pena que você não vai estar vivo para presenciar esse evento.");
                                    Console.WriteLine("[Xerife] Um bandido tão perigoso quanto você não vai reviver enquanto eu for o Xerife!");
                                    Console.WriteLine("        `.hs+                                                                            shd..       ");
                                    Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                    Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                    Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                    Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                    Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                    Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                    Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                    Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                    Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                    Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                    Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                    Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                    Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                    Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                    Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                    Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                    Console.ReadKey();
                                    Console.Clear();
                                    tempus = 0;
                                    tempus10 = 0;
                                    do
                                    {
                                        Console.WriteLine("Dia 3, Trem do Meio-dia, 12:{0}{1}", tempus10,tempus);
                                        Console.WriteLine("É meio dia.");
                                        Console.WriteLine("        `.hs+                                                                            shd..       ");
                                        Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                        Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                        Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                        Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                        Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                        Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                        Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                        Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                        Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                        Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                        Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                        Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                        Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                        Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                        Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                        Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                        Console.WriteLine("Xerife, faça a sua decisão: (1)Atirar  (2)Recarregar  (3)Esquivar");
                                        escolha = int.Parse(Console.ReadLine());
                                        Console.Clear();



                                        if (escolha == 1)
                                        {
                                            Console.WriteLine("Xerife sacou o seu revólver...");
                                            if (bala < 1)
                                            {
                                                Console.WriteLine("Mas estava sem balas!");
                                                escolha = 4;
                                            }
                                            else
                                            {
                                                Console.WriteLine("E apertou o gatilho!");
                                                bala--;
                                            }
                                        }
                                        else if (escolha == 2)
                                        {
                                            Console.WriteLine("Xerife decidiu colocar uma bala em seu revólver...");
                                            bala++;
                                        }
                                        else if (escolha == 3)
                                        {
                                            Console.WriteLine("Xerife decidiu se esquivar para escapar do tiro...");
                                        }

                                        Random rand = new Random();
                                        escolha2 = rand.Next(1, 3);
                                        if (primeiroturno == 0)
                                        {
                                            Console.WriteLine("Esqueleto decidiu colocar uma bala em seu revólver...");
                                            bala2++;
                                            primeiroturno = 1;
                                            escolha2 = 2;
                                        }
                                        else
                                        {
                                            if (escolha2 == 1)
                                            {
                                                Console.WriteLine("Esqueleto sacou o seu revólver...");
                                                if (bala2 < 1)
                                                {
                                                    Console.WriteLine("Mas estava sem balas!");
                                                    escolha2 = 4;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("E apertou o gatilho!");
                                                    bala2--;
                                                }
                                            }
                                            else if (escolha2 == 2)
                                            {
                                                Console.WriteLine("Esqueleto decidiu colocar uma bala em seu revólver...");
                                                bala2++;
                                            }
                                            else if (escolha2 == 3)
                                            {
                                                Console.WriteLine("Esqueleto decidiu se esquivar para escapar do tiro...");
                                            }

                                        }
                 
                                        if (escolha == 1 && escolha2 == 1)
                                        {
                                            Console.WriteLine("       ..dhs                                                                            shd..       ");
                                            Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                            Console.WriteLine("     -osNMMd/..```    ```                                                  ```    ```../dMMNso-     ");
                                            Console.WriteLine("    .mMMMMMNddmmdhyyhyms/-:-                                            -:-/smyhyyhdmmddNMMMMMm.    ");
                                            Console.WriteLine("    hNNMMMMo   ````..::                                                      ::..````   oMMMMNNh    ");
                                            Console.WriteLine("   :NsdMMMM/                                                                            /MMMMdsN:   ");
                                            Console.WriteLine("   hm`dMMMMs                                                                            sMMMMd`mh   ");
                                            Console.WriteLine("  :No-NMMMMh                                                                            hMMMMN-oN:  ");
                                            Console.WriteLine("  /N/NMMmMMm-                                                                          -mMMmMMN/N/ ");
                                            Console.WriteLine("  syyMMd.NMM:                                                                          :MMN.dMMyys  ");
                                            Console.WriteLine("  s`sMN: sMm`                                                                          `mMs :NMs`s  ");
                                            Console.WriteLine("  . dMs  -MN`                                                                          `NM-  sMd .  ");
                                            Console.WriteLine("   /MN`  `NM-                                                                          -MN`  `NM/  ");
                                            Console.WriteLine("   mM+    hMo                                                                          oMh    +Mm  ");
                                            Console.WriteLine("  oMd     .Nd                                                                          dN.     dMo  ");
                                            Console.WriteLine("`oNN/.`    hNyo:`                                                                  `:oyNh    `./NNo`");
                                            Console.WriteLine(" .-yydmhsooydMMNmmmmhssso+++:-                                        -:+++ossshmmmmNMMdyooshmdyy-. ");
                                            Console.WriteLine("     `:ydNMMMMMMMMMMdo----:::-                                        -:::----odMMMMMMMMMMNdy:`     ");
                                            Console.WriteLine("         `...../ooo+:`                                                        `:+ooo/.....`         ");
                                            Console.WriteLine("Os dois caubóis atiram ao mesmo tempo! Cada bala ricocheteia a outra, que explodem no ar!");

                                        }
                                        if (escolha == 1 && escolha2 == 2 || escolha == 1 && escolha2 == 4)
                                        {

                                            morte = 1;
                                            a = 1;

                                            Console.WriteLine("        ..dhs                                                                                        ");
                                            Console.WriteLine("       `dMMm-`                                                                                      ");
                                            Console.WriteLine("     -osNMMd/..```    ```                                                                           ");
                                            Console.WriteLine("    .mMMMMMNddmmdhyyhyms/-:-                                          `                 .           ");
                                            Console.WriteLine("   hNNMMMMo   ````..::                                              +h/       .-.     -h-          ");
                                            Console.WriteLine("   :NsdMMMM/                                                         `dd-    ` dMN-    ymh`         ");
                                            Console.WriteLine("   hm`dMMMMs                                                          `ydyyhhhyNMm-   `:``          ");
                                            Console.WriteLine("  :No-NMMMMh                                                            .:yMMMMMMNh.                ");
                                            Console.WriteLine("  /N/NMMmMMm-                                                          .+mMMMMMNdmMy`               ");
                                            Console.WriteLine("  syyMMd.NMM:                                                         :mMMMMms:-`.hMy:--.+:-        ");
                                            Console.WriteLine("  s`sMN: sMm`                                                       `+NMMMm+`     `+shhhoss:        ");
                                            Console.WriteLine("  . dMs  -MN`                                                       sMMMm+.           ``            ");
                                            Console.WriteLine("   /MN`  `NM-                                                       dMNdmmho-                       ");
                                            Console.WriteLine("   mM+    hMo                                                       -hNmo:+hmh.                     ");
                                            Console.WriteLine("  oMd     .Nd                                                        `:yNd-.ms                      ");
                                            Console.WriteLine("`oNN/.`    hNyo:`                                                      `/Nh`.  ``   .-.             ");
                                            Console.WriteLine(" .-yydmhsooydMMNmmmmhssso+++:-                                         `+hdhsyhmNdhsdNNmh:    .::-` ");
                                            Console.WriteLine("     `:ydNMMMMMMMMMMdo----:::-                                           ``./oyddmNMMMMMMNy/. `omNd`");
                                            Console.WriteLine("         `...../ooo+:`                                                           ``.+hMMMMMNd   `:+.");
                                            Console.WriteLine("                                                                                   /yss+//.         ");


                                            Console.WriteLine("O Xerife atira mais rápido, acertando em cheio o Esqueleto");

                                        }
                                        if (escolha == 1 && escolha2 == 3)
                                        {

                                            Console.WriteLine("        `.hs+                                                                            shd..       ");
                                            Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                            Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                            Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                            Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                            Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                            Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                            Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                            Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                            Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                            Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                            Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                            Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                            Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                            Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                            Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                            Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                            Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                            Console.WriteLine("O Xerife efetua o disparo, mas o Esqueleto rapidamente se esquiva!");
                                        }
                                        if (escolha == 2 && escolha2 == 2)
                                        {
                                            Console.WriteLine("        `.hs+                                                                            shd..       ");
                                            Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                            Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                            Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                            Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                            Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                            Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                            Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                            Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                            Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                            Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                            Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                            Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                            Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                            Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                            Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                            Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                            Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                            Console.WriteLine("Os dois caubóis decidem recarregar ao mesmo tempo!");
                                        }


                                        if (escolha == 2 && escolha2 == 1 || escolha == 4 && escolha2 == 1)
                                        {
                                            Console.WriteLine("                                                                                         shd..");
                                            Console.WriteLine("                                                                                      `-mMMd` ");
                                            Console.WriteLine("                                                                           ```    ```../dMMNso- ");
                                            Console.WriteLine("           .                 `                                          -:-/smyhyyhdmmddNMMMMMm. ");
                                            Console.WriteLine("          -h-     .-.       /h+                                              ::..````   oMMMMNNh   ");
                                            Console.WriteLine("         `hmy    -NMd `    -dd`                                                         /MMMMdsN:   ");
                                            Console.WriteLine("          ``:`   -mMNyhhhyydy`                                                          sMMMMd`mh   ");
                                            Console.WriteLine("                .hNMMMMMMy:.                                                            hMMMMN-oN:  ");
                                            Console.WriteLine("               `yMmdNMMMMMm+.                                                          -mMMmMMN/N/  ");
                                            Console.WriteLine("        -:+.--:yMh.`-:smMMMMm:                                                         :MMN.dMMyys  ");
                                            Console.WriteLine("        :ssohhhs+`     `+mMMMN+`                                                       `mMs :NMs`s  ");
                                            Console.WriteLine("            ``           .+mMMMs                                                       `NM-  sMd .  ");
                                            Console.WriteLine("                       -ohmmdNMd                                                       -MN`  `NM/   ");
                                            Console.WriteLine("                     .hmh+:omNh-                                                       oMh    +Mm   ");
                                            Console.WriteLine("                      sm.-dNy:`                                                        dN.     dMo  ");
                                            Console.WriteLine("             .-.   ``  .`hN/`                                                      `:oyNh    `./NNo`");
                                            Console.WriteLine(" `-::.    :hmNNdshdNmhyshdh+`                                         -:+++ossshmmmmNMMdyooshmdyy-. ");
                                            Console.WriteLine("`dNmo` ./yNMMMMMMNmddyo/.``                                           -:::----odMMMMMMMMMMNdy:`     ");
                                            Console.WriteLine(".+:`   dNMMMMMh+.``                                                           `:+ooo/.....`         ");
                                            Console.WriteLine("         .//+ssy/                                                                                   ");
                                            morte = 1;
                                            a = 2;

                                            Console.WriteLine("O Esqueleto atira mais rápido, acertando em cheio o Xerife!");
                                        }
                                        if (escolha == 3 && escolha2 == 1)
                                        {
                                            Console.WriteLine("        `.hs+                                                                            shd..       ");
                                            Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                            Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                            Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                            Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                            Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                            Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                            Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                            Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                            Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                            Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                            Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                            Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                            Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                            Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                            Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                            Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                            Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                            Console.WriteLine("O Esqueleto efetua o disparo, mas o Xerife rapidamente se esquiva!");

                                        }

                                        if (escolha == 3 && escolha2 == 3)
                                        {
                                            Console.WriteLine("        `.hs+                                                                            shd..       ");
                                            Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                            Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                            Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                            Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                            Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                            Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                            Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                            Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                            Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                            Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                            Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                            Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                            Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                            Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                            Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                            Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                            Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                            Console.WriteLine("Os dois caubóis escolhem se esquivar e ninguém atira!");
                                        }

                                        if (escolha == 3 && escolha2 == 2 || escolha == 2 && escolha2 == 3 || escolha == 4 && escolha2 == 4 || escolha == 3 && escolha2 == 4 || escolha == 4 && escolha2 == 3 || escolha == 2 && escolha2 == 4 || escolha == 4 && escolha2 == 2)
                                        {
                                            Console.WriteLine("        `.hs+                                                                            shd..       ");
                                            Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                            Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                            Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                            Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                            Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                            Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                            Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                            Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                            Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                            Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                            Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                            Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                            Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                            Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                            Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                            Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                            Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                            Console.WriteLine("Ninguém decide atacar neste turno!");
                                        }


                                        Console.ReadKey();
                                        Console.Clear();
                                        tempus++;
                                        if (tempus >= 10)
                                        {
                                            tempus = 0;
                                            tempus10++;
                                        }
                                        if (tempus10 == 6)
                                        {
                                            a = 3;
                                            morte = 1;
                                        }
                                    }
                                    while (morte != 1);
                                    if (a == 1)
                                    {
                                        Console.WriteLine("Dia 3, Trem do Meio-dia, 12:{0}{1}",tempus10,tempus);
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.Clear();
                                        Console.WriteLine("              MM                                              MM,");
                                        Console.WriteLine("            O8M~                                               M M");
                                        Console.WriteLine("          7N :M,                                               MN  M=");
                                        Console.WriteLine("        ?M   M M                                               MM    8N ");
                                        Console.WriteLine("      =M    M.  M:                                            MIMMMD   :M");
                                        Console.WriteLine("    :M      M     M+                                        .M  ,+  :MMM? M.");
                                        Console.WriteLine("   M.      M        M=                                     MI    M      +MMMM");
                                        Console.WriteLine(" M,       .7           MM,                             OMZ       M           M");
                                        Console.WriteLine("M         M              :MM$MMMM$=,         ,=$MMMM.            7.           M");
                                        Console.WriteLine("+        M             MM+  M                    MM MM            M           O");
                                        Console.WriteLine("        M          MM        8                  M      $M         M.           M");
                                        Console.WriteLine("       +O        MM           M                M?        M~       ~O           I");
                                        Console.WriteLine("M      M      :MM              M              MM          $M       M          M ");
                                        Console.WriteLine("  M  M ~MN                       M          M.                 MM   M      M   ");
                                        Console.WriteLine("   MNMMM                          M        MM                   $M  M     M    ");
                                        Console.WriteLine("    M=                            I+      MM                      MMM=  M      ");
                                        Console.WriteLine("       MI$M=                        M    M.                     :MMN~          ");
                                        Console.WriteLine("         M?  MM?                     M  M7                  ~MM  :M            ");
                                        Console.WriteLine("           M    OMM+                 D~~M                7MM    M~             ");
                                        Console.WriteLine("             M      :MMMM~            MM           ~MMMM      ,M               ");
                                        Console.WriteLine("               M      M:   ~$MMMMMMMMMMMMMMMMMMI.    =8      M                 ");
                                        Console.WriteLine("                .M     ZM             M,            $7     .=             ");
                                        Console.WriteLine("                    M$    M=           M          M,    D+       ");
                                        Console.WriteLine("                        M    M         M        M=   D?          ");
                                        Console.WriteLine("                          M   M        M       M,  .M          ");
                                        Console.WriteLine("                            M  :M      M      M.  M        ");
                                        Console.WriteLine("                             .M  M     Z     M  O7      ");
                                        Console.WriteLine("                               M7 M    =:   M, M      ");
                                        Console.WriteLine("                                 MIOO   D  M.Z7 ");
                                        Console.WriteLine("                                   M=M  M M M   ");
                                        Console.WriteLine("                                     MM:MMM       ");
                                        Console.WriteLine("                                        :      ");
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("O maquinista avisa aos passageiros que o trem chegou à cidade de Silverneck");
                                        //imagem de trem aqui
                                        Console.WriteLine("O Xerife volta para a delegacia com o tesouro da cidade, o diamante de Silverneck.");
                                        //imagem de um diamante ou da delegacia talvez
                                        Console.WriteLine("E ele continuará espalhando a sua justiça enquanto houver pessoas agindo de má fé no velho oeste.");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                            }
                            Console.WriteLine(" _______  ___   __   __    ______   _______        ___  _______  _______  _______");
                            Console.WriteLine("|       ||   | |  |_|  |  |      | |       |      |   ||       ||       ||       |");
                            Console.WriteLine("|    ___||   | |       |  |  _    ||    ___|      |   ||   _   ||    ___||   _   |");
                            Console.WriteLine("|   |___ |   | |       |  | | |   ||   |___       |   ||  | |  ||   | __ |  | |  |");
                            Console.WriteLine("|    ___||   | |       |  | |_|   ||    ___|   ___|   ||  |_|  ||   ||  ||  |_|  |");
                            Console.WriteLine("|   |    |   | | ||_|| |  |       ||   |___   |       ||       ||   |_| ||       |");
                            Console.WriteLine("|___|    |___| |_|   |_|  |______| |_______|  |_______||_______||_______||_______|");
                            Console.WriteLine("           _______  _______  _     _  _______  _______  __   __                  ");
                            Console.WriteLine("          |     __||       || | _ | ||  _    ||       ||  | |  |                 ");
                            Console.WriteLine("          |    |   |   _   || || || || |_|   ||   _   ||  |_|  |                  ");
                            Console.WriteLine("          |    |   |  | |  ||       ||       ||  | |  ||       |                  ");
                            Console.WriteLine("          |    |   |  |_|  ||       ||  _   | |  |_|  ||_     _|                  ");
                            Console.WriteLine("          |    |__ |       ||   _   || |_|   ||       |  |   |                    ");
                            Console.WriteLine("          |_______||_______||__| |__||_______||_______|  |___|                    ");
                            if (a == 3)
                                Console.WriteLine("Tempo esgotado! Você perdeu!");
                            Console.ReadKey();
                        }

                        //PARTE DO CAÇADOR DE RECMPENSAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
                        else if (pers == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("Dia 1, Saloon de Silverneck, 11:58");
                            Console.WriteLine("[Caçador de Recompensas] Olha só quem eu acabo de encontrar por aqui.");
                            Console.WriteLine("[Ladrão] Nem vai me pagar uma bebida antes de tentar me matar?");
                            Console.WriteLine("        `.hs+                                                                            shd..       ");
                            Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                            Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                            Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                            Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                            Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                            Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                            Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                            Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                            Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                            Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                            Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                            Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                            Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                            Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                            Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                            Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                            Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Dia 1, Saloon de Silverneck, 11:59");
                            Console.WriteLine("[Caçador de Recompensas] Não tenho tempo para as suas gracinhas. Prepare-se para morrer.");
                            Console.WriteLine("        `.hs+                                                                            shd..       ");
                            Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                            Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                            Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                            Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                            Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                            Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                            Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                            Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                            Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                            Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                            Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                            Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                            Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                            Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                            Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                            Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                            Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                            Console.ReadKey();
                            Console.Clear();
                            do
                            {
                                Console.WriteLine("Dia 1, Saloon de Silverneck, 12:{0}{1}", tempus10,tempus);
                                Console.WriteLine("É meio dia.");
                                Console.WriteLine("        `.hs+                                                                            shd..       ");
                                Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                Console.WriteLine("Caçador de Recompensas, faça a sua decisão: (1)Atirar  (2)Recarregar  (3)Esquivar");
                                escolha = int.Parse(Console.ReadLine());
                                Console.Clear();



                                if (escolha == 1)
                                {
                                    Console.WriteLine("Caçador de Recompensas sacou o seu revólver...");
                                    if (bala < 1)
                                    {
                                        Console.WriteLine("Mas estava sem balas!");
                                        escolha = 4;
                                    }
                                    else
                                    {
                                        Console.WriteLine("E apertou o gatilho!");
                                        bala--;
                                    }
                                }
                                else if (escolha == 2)
                                {
                                    Console.WriteLine("Caçador de Recompensas decidiu colocar uma bala em seu revólver...");
                                    bala++;
                                }
                                else if (escolha == 3)
                                {
                                    Console.WriteLine("Caçador de Recompensas decidiu se esquivar para escapar do tiro...");
                                }

                                Random rand = new Random();


                                if (primeiroturno == 0)
                                {
                                    Console.WriteLine("Ladrão decidiu colocar uma bala em seu revólver...");
                                    bala2++;
                                    primeiroturno = 1;
                                    escolha2 = 2;
                                }
                                else
                                {
                                    if (bala2 > 0)
                                    {
                                        if (bala > 0)
                                        {
                                            int auxescolha;
                                            auxescolha = rand.Next(1, 3);
                                            if (auxescolha == 1)
                                            {
                                                escolha2 = 1;
                                            }
                                            else
                                                escolha2 = 3;

                                        }
                                        else
                                        {
                                            escolha2 = 1;
                                        }
                                    }
                                    else
                                    {
                                        escolha2 = rand.Next(2, 4);
                                    }

                                    if (escolha2 == 1)
                                    {
                                        Console.WriteLine("Ladrão sacou o seu revólver...");
                                        if (bala2 < 1)
                                        {
                                            Console.WriteLine("Mas estava sem balas!");
                                            escolha2 = 4;
                                        }
                                        else
                                        {
                                            Console.WriteLine("E apertou o gatilho!");
                                            bala2--;
                                        }
                                    }
                                    else if (escolha2 == 2)
                                    {
                                        Console.WriteLine("Ladrão decidiu colocar uma bala em seu revólver...");
                                        bala2++;
                                    }
                                    else if (escolha2 == 3)
                                    {
                                        Console.WriteLine("Ladrão decidiu se esquivar para escapar do tiro...");
                                    }

                                }

                                if (escolha == 1 && escolha2 == 1)
                                {
                                    Console.WriteLine("       ..dhs                                                                            shd..       ");
                                    Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                    Console.WriteLine("     -osNMMd/..```    ```                                                  ```    ```../dMMNso-     ");
                                    Console.WriteLine("    .mMMMMMNddmmdhyyhyms/-:-                                            -:-/smyhyyhdmmddNMMMMMm.    ");
                                    Console.WriteLine("    hNNMMMMo   ````..::                                                      ::..````   oMMMMNNh    ");
                                    Console.WriteLine("   :NsdMMMM/                                                                            /MMMMdsN:   ");
                                    Console.WriteLine("   hm`dMMMMs                                                                            sMMMMd`mh   ");
                                    Console.WriteLine("  :No-NMMMMh                                                                            hMMMMN-oN:  ");
                                    Console.WriteLine("  /N/NMMmMMm-                                                                          -mMMmMMN/N/ ");
                                    Console.WriteLine("  syyMMd.NMM:                                                                          :MMN.dMMyys  ");
                                    Console.WriteLine("  s`sMN: sMm`                                                                          `mMs :NMs`s  ");
                                    Console.WriteLine("  . dMs  -MN`                                                                          `NM-  sMd .  ");
                                    Console.WriteLine("   /MN`  `NM-                                                                          -MN`  `NM/  ");
                                    Console.WriteLine("   mM+    hMo                                                                          oMh    +Mm  ");
                                    Console.WriteLine("  oMd     .Nd                                                                          dN.     dMo  ");
                                    Console.WriteLine("`oNN/.`    hNyo:`                                                                  `:oyNh    `./NNo`");
                                    Console.WriteLine(" .-yydmhsooydMMNmmmmhssso+++:-                                        -:+++ossshmmmmNMMdyooshmdyy-. ");
                                    Console.WriteLine("     `:ydNMMMMMMMMMMdo----:::-                                        -:::----odMMMMMMMMMMNdy:`     ");
                                    Console.WriteLine("         `...../ooo+:`                                                        `:+ooo/.....`         ");
                                    Console.WriteLine("Os dois caubóis atiram ao mesmo tempo! Cada bala ricocheteia a outra, que explodem no ar!");

                                }
                                if (escolha == 1 && escolha2 == 2 || escolha == 1 && escolha2 == 4)
                                {

                                    morte = 1;
                                    a = 1;

                                    Console.WriteLine("        ..dhs                                                                                        ");
                                    Console.WriteLine("       `dMMm-`                                                                                      ");
                                    Console.WriteLine("     -osNMMd/..```    ```                                                                           ");
                                    Console.WriteLine("    .mMMMMMNddmmdhyyhyms/-:-                                          `                 .           ");
                                    Console.WriteLine("   hNNMMMMo   ````..::                                              +h/       .-.     -h-          ");
                                    Console.WriteLine("   :NsdMMMM/                                                         `dd-    ` dMN-    ymh`         ");
                                    Console.WriteLine("   hm`dMMMMs                                                          `ydyyhhhyNMm-   `:``          ");
                                    Console.WriteLine("  :No-NMMMMh                                                            .:yMMMMMMNh.                ");
                                    Console.WriteLine("  /N/NMMmMMm-                                                          .+mMMMMMNdmMy`               ");
                                    Console.WriteLine("  syyMMd.NMM:                                                         :mMMMMms:-`.hMy:--.+:-        ");
                                    Console.WriteLine("  s`sMN: sMm`                                                       `+NMMMm+`     `+shhhoss:        ");
                                    Console.WriteLine("  . dMs  -MN`                                                       sMMMm+.           ``            ");
                                    Console.WriteLine("   /MN`  `NM-                                                       dMNdmmho-                       ");
                                    Console.WriteLine("   mM+    hMo                                                       -hNmo:+hmh.                     ");
                                    Console.WriteLine("  oMd     .Nd                                                        `:yNd-.ms                      ");
                                    Console.WriteLine("`oNN/.`    hNyo:`                                                      `/Nh`.  ``   .-.             ");
                                    Console.WriteLine(" .-yydmhsooydMMNmmmmhssso+++:-                                         `+hdhsyhmNdhsdNNmh:    .::-` ");
                                    Console.WriteLine("     `:ydNMMMMMMMMMMdo----:::-                                           ``./oyddmNMMMMMMNy/. `omNd`");
                                    Console.WriteLine("         `...../ooo+:`                                                           ``.+hMMMMMNd   `:+.");
                                    Console.WriteLine("                                                                                   /yss+//.         ");


                                    Console.WriteLine("O Caçador de Recompensas atira mais rápido, acertando em cheio o Ladrão");

                                }
                                if (escolha == 1 && escolha2 == 3)
                                {

                                    Console.WriteLine("        `.hs+                                                                            shd..       ");
                                    Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                    Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                    Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                    Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                    Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                    Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                    Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                    Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                    Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                    Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                    Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                    Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                    Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                    Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                    Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                    Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                    Console.WriteLine("O Caçador de Recompensas efetua o disparo, mas o Ladrão rapidamente se esquiva!");
                                }
                                if (escolha == 2 && escolha2 == 2)
                                {
                                    Console.WriteLine("        `.hs+                                                                            shd..       ");
                                    Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                    Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                    Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                    Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                    Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                    Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                    Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                    Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                    Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                    Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                    Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                    Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                    Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                    Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                    Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                    Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                    Console.WriteLine("Os dois caubóis decidem recarregar ao mesmo tempo!");
                                }


                                if (escolha == 2 && escolha2 == 1 || escolha == 4 && escolha2 == 1)
                                {
                                    Console.WriteLine("                                                                                         shd..");
                                    Console.WriteLine("                                                                                      `-mMMd` ");
                                    Console.WriteLine("                                                                           ```    ```../dMMNso- ");
                                    Console.WriteLine("           .                 `                                          -:-/smyhyyhdmmddNMMMMMm. ");
                                    Console.WriteLine("          -h-     .-.       /h+                                              ::..````   oMMMMNNh   ");
                                    Console.WriteLine("         `hmy    -NMd `    -dd`                                                         /MMMMdsN:   ");
                                    Console.WriteLine("          ``:`   -mMNyhhhyydy`                                                          sMMMMd`mh   ");
                                    Console.WriteLine("                .hNMMMMMMy:.                                                            hMMMMN-oN:  ");
                                    Console.WriteLine("               `yMmdNMMMMMm+.                                                          -mMMmMMN/N/  ");
                                    Console.WriteLine("        -:+.--:yMh.`-:smMMMMm:                                                         :MMN.dMMyys  ");
                                    Console.WriteLine("        :ssohhhs+`     `+mMMMN+`                                                       `mMs :NMs`s  ");
                                    Console.WriteLine("            ``           .+mMMMs                                                       `NM-  sMd .  ");
                                    Console.WriteLine("                       -ohmmdNMd                                                       -MN`  `NM/   ");
                                    Console.WriteLine("                     .hmh+:omNh-                                                       oMh    +Mm   ");
                                    Console.WriteLine("                      sm.-dNy:`                                                        dN.     dMo  ");
                                    Console.WriteLine("             .-.   ``  .`hN/`                                                      `:oyNh    `./NNo`");
                                    Console.WriteLine(" `-::.    :hmNNdshdNmhyshdh+`                                         -:+++ossshmmmmNMMdyooshmdyy-. ");
                                    Console.WriteLine("`dNmo` ./yNMMMMMMNmddyo/.``                                           -:::----odMMMMMMMMMMNdy:`     ");
                                    Console.WriteLine(".+:`   dNMMMMMh+.``                                                           `:+ooo/.....`         ");
                                    Console.WriteLine("         .//+ssy/                                                                                   ");

                                    morte = 1;
                                    a = 2;

                                    Console.WriteLine("O Ladrão atira mais rápido, acertando em cheio o Caçador de Recompensas!");
                                }
                                if (escolha == 3 && escolha2 == 1)
                                {
                                    Console.WriteLine("        `.hs+                                                                            shd..       ");
                                    Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                    Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                    Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                    Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                    Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                    Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                    Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                    Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                    Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                    Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                    Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                    Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                    Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                    Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                    Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                    Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                    Console.WriteLine("O Ladrão efetua o disparo, mas o Caçador de Recompensas rapidamente se esquiva!");

                                }

                                if (escolha == 3 && escolha2 == 3)
                                {
                                    Console.WriteLine("        `.hs+                                                                            shd..       ");
                                    Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                    Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                    Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                    Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                    Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                    Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                    Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                    Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                    Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                    Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                    Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                    Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                    Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                    Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                    Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                    Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                    Console.WriteLine("Os dois caubóis escolhem se esquivar e ninguém atira!");
                                }

                                if (escolha == 3 && escolha2 == 2 || escolha == 2 && escolha2 == 3 || escolha == 4 && escolha2 == 4 || escolha == 3 && escolha2 == 4 || escolha == 4 && escolha2 == 3 || escolha == 2 && escolha2 == 4 || escolha == 4 && escolha2 == 2)
                                {
                                    Console.WriteLine("        `.hs+                                                                            shd..       ");
                                    Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                    Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                    Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                    Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                    Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                    Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                    Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                    Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                    Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                    Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                    Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                    Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                    Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                    Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                    Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                    Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                    Console.WriteLine("Ninguém decide atacar neste turno!");
                                }

                                Console.ReadKey();
                                Console.Clear();
                                tempus++;
                                if (tempus >= 10)
                                {
                                    tempus = 0;
                                    tempus10++;
                                }
                                if (tempus10 == 6)
                                {
                                    a = 3;
                                    morte = 1;
                                }
                            }
                            while (morte != 1);

                            if (a == 1)
                            {

                                // PARTE 2 HISTÓRIA DO CAÇADOR DE RECOMPENSAS
                                morte = 0;
                                a = 0;
                                bala = 0;
                                bala2 = 0;
                                primeiroturno = 0;

                                Console.WriteLine("Dia 1, Saloon de Silverneck, 12:{0}{1}", tempus10,tempus);
                                Console.WriteLine("[Caçador de Recompensas] Patético. Não sei por quê colocaram uma recompensa tão alta nesse cara.");
                                Console.WriteLine("        ..dhs                                                                                        ");
                                Console.WriteLine("       `dMMm-`                                                                                      ");
                                Console.WriteLine("     -osNMMd/..```    ```                                                                           ");
                                Console.WriteLine("    .mMMMMMNddmmdhyyhyms/-:-                                          `                 .           ");
                                Console.WriteLine("   hNNMMMMo   ````..::                                              +h/       .-.     -h-          ");
                                Console.WriteLine("   :NsdMMMM/                                                         `dd-    ` dMN-    ymh`         ");
                                Console.WriteLine("   hm`dMMMMs                                                          `ydyyhhhyNMm-   `:``          ");
                                Console.WriteLine("  :No-NMMMMh                                                            .:yMMMMMMNh.                ");
                                Console.WriteLine("  /N/NMMmMMm-                                                          .+mMMMMMNdmMy`               ");
                                Console.WriteLine("  syyMMd.NMM:                                                         :mMMMMms:-`.hMy:--.+:-        ");
                                Console.WriteLine("  s`sMN: sMm`                                                       `+NMMMm+`     `+shhhoss:        ");
                                Console.WriteLine("  . dMs  -MN`                                                       sMMMm+.           ``            ");
                                Console.WriteLine("   /MN`  `NM-                                                       dMNdmmho-                       ");
                                Console.WriteLine("   mM+    hMo                                                       -hNmo:+hmh.                     ");
                                Console.WriteLine("  oMd     .Nd                                                        `:yNd-.ms                      ");
                                Console.WriteLine("`oNN/.`    hNyo:`                                                      `/Nh`.  ``   .-.             ");
                                Console.WriteLine(" .-yydmhsooydMMNmmmmhssso+++:-                                         `+hdhsyhmNdhsdNNmh:    .::-` ");
                                Console.WriteLine("     `:ydNMMMMMMMMMMdo----:::-                                           ``./oyddmNMMMMMMNy/. `omNd`");
                                Console.WriteLine("         `...../ooo+:`                                                           ``.+hMMMMMNd   `:+.");
                                Console.WriteLine("                                                                                   /yss+//.         ");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("Dia 2, Delegacia, 11:58");
                                Console.WriteLine("[Caçador de Recompensas] Ei, Xerife! Aqui está a cabeça do Ladrão. Me dê logo a recompensa.");
                                Console.WriteLine("[Xerife] O Esqueleto roubou o Diamante que eu ia dar como recompensa. Por favor, espere até que eu consiga capturá-lo.");
                                Console.WriteLine("        `.hs+                                                                            shd..       ");
                                Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("Dia 2, Delegacia, 11:59");
                                Console.WriteLine("[Caçador de Recompensas] Não tenho tempo para as suas desculpas, Xerife. Essa cidade está cheia de incompetentes, e você é um deles.");
                                Console.WriteLine("[Xerife] Então eu acho que você acabou de entrar para a minha lista de inimigos públicos, caubói.");
                                Console.WriteLine("        `.hs+                                                                            shd..       ");
                                Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                Console.ReadKey();
                                Console.Clear();
                                tempus = 0;
                                tempus10 = 0;
                                do
                                {
                                    Console.WriteLine("Dia 2, Delegacia, 12:{0}{1}", tempus10,tempus);
                                    Console.WriteLine("É meio dia.");
                                    Console.WriteLine("        `.hs+                                                                            shd..       ");
                                    Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                    Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                    Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                    Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                    Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                    Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                    Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                    Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                    Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                    Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                    Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                    Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                    Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                    Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                    Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                    Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                    Console.WriteLine("Caçador de Recompensas, faça a sua decisão: (1)Atirar  (2)Recarregar  (3)Esquivar");
                                    escolha = int.Parse(Console.ReadLine());
                                    Console.Clear();



                                    if (escolha == 1)
                                    {
                                        Console.WriteLine("Caçador de Recompensas sacou o seu revólver...");
                                        if (bala < 1)
                                        {
                                            Console.WriteLine("Mas estava sem balas!");
                                            escolha = 4;
                                        }
                                        else
                                        {
                                            Console.WriteLine("E apertou o gatilho!");
                                            bala++;
                                        }
                                    }
                                    else if (escolha == 2)
                                    {
                                        Console.WriteLine("Caçador de Recompensas decidiu colocar uma bala em seu revólver...");
                                        bala++;
                                    }
                                    else if (escolha == 3)
                                    {
                                        Console.WriteLine("Caçador de Recompensas decidiu se esquivar para escapar do tiro...");
                                    }

                                    Random rand = new Random();
                                    escolha2 = rand.Next(1, 3);
                                    if (primeiroturno == 0)
                                    {
                                        Console.WriteLine("Xerife decidiu colocar uma bala em seu revólver...");
                                        bala2++;
                                        primeiroturno = 1;
                                        escolha2 = 2;
                                    }
                                    else
                                    {
                                        if (escolha2 == 1)
                                        {
                                            Console.WriteLine("Xerife sacou o seu revólver...");
                                            if (bala2 < 1)
                                            {
                                                Console.WriteLine("Mas estava sem balas!");
                                                escolha2 = 4;
                                            }
                                            else
                                            {
                                                Console.WriteLine("E apertou o gatilho!");
                                                bala2--;
                                            }
                                        }
                                        else if (escolha2 == 2)
                                        {
                                            Console.WriteLine("Xerife decidiu colocar uma bala em seu revólver...");
                                            bala2++;
                                        }
                                        else if (escolha2 == 3)
                                        {
                                            Console.WriteLine("Xerife decidiu se esquivar para escapar do tiro...");
                                        }

                                    }
                                    if (escolha == 1 && escolha2 == 1)
                                    {
                                        Console.WriteLine("       ..dhs                                                                            shd..       ");
                                        Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                        Console.WriteLine("     -osNMMd/..```    ```                                                  ```    ```../dMMNso-     ");
                                        Console.WriteLine("    .mMMMMMNddmmdhyyhyms/-:-                                            -:-/smyhyyhdmmddNMMMMMm.    ");
                                        Console.WriteLine("    hNNMMMMo   ````..::                                                      ::..````   oMMMMNNh    ");
                                        Console.WriteLine("   :NsdMMMM/                                                                            /MMMMdsN:   ");
                                        Console.WriteLine("   hm`dMMMMs                                                                            sMMMMd`mh   ");
                                        Console.WriteLine("  :No-NMMMMh                                                                            hMMMMN-oN:  ");
                                        Console.WriteLine("  /N/NMMmMMm-                                                                          -mMMmMMN/N/ ");
                                        Console.WriteLine("  syyMMd.NMM:                                                                          :MMN.dMMyys  ");
                                        Console.WriteLine("  s`sMN: sMm`                                                                          `mMs :NMs`s  ");
                                        Console.WriteLine("  . dMs  -MN`                                                                          `NM-  sMd .  ");
                                        Console.WriteLine("   /MN`  `NM-                                                                          -MN`  `NM/  ");
                                        Console.WriteLine("   mM+    hMo                                                                          oMh    +Mm  ");
                                        Console.WriteLine("  oMd     .Nd                                                                          dN.     dMo  ");
                                        Console.WriteLine("`oNN/.`    hNyo:`                                                                  `:oyNh    `./NNo`");
                                        Console.WriteLine(" .-yydmhsooydMMNmmmmhssso+++:-                                        -:+++ossshmmmmNMMdyooshmdyy-. ");
                                        Console.WriteLine("     `:ydNMMMMMMMMMMdo----:::-                                        -:::----odMMMMMMMMMMNdy:`     ");
                                        Console.WriteLine("         `...../ooo+:`                                                        `:+ooo/.....`         ");
                                        Console.WriteLine("Os dois caubóis atiram ao mesmo tempo! Cada bala ricocheteia a outra, que explodem no ar!");

                                    }
                                    if (escolha == 1 && escolha2 == 2 || escolha == 1 && escolha2 == 4)
                                    {

                                        morte = 1;
                                        a = 1;

                                        Console.WriteLine("        ..dhs                                                                                        ");
                                        Console.WriteLine("       `dMMm-`                                                                                      ");
                                        Console.WriteLine("     -osNMMd/..```    ```                                                                           ");
                                        Console.WriteLine("    .mMMMMMNddmmdhyyhyms/-:-                                          `                 .           ");
                                        Console.WriteLine("   hNNMMMMo   ````..::                                              +h/       .-.     -h-          ");
                                        Console.WriteLine("   :NsdMMMM/                                                         `dd-    ` dMN-    ymh`         ");
                                        Console.WriteLine("   hm`dMMMMs                                                          `ydyyhhhyNMm-   `:``          ");
                                        Console.WriteLine("  :No-NMMMMh                                                            .:yMMMMMMNh.                ");
                                        Console.WriteLine("  /N/NMMmMMm-                                                          .+mMMMMMNdmMy`               ");
                                        Console.WriteLine("  syyMMd.NMM:                                                         :mMMMMms:-`.hMy:--.+:-        ");
                                        Console.WriteLine("  s`sMN: sMm`                                                       `+NMMMm+`     `+shhhoss:        ");
                                        Console.WriteLine("  . dMs  -MN`                                                       sMMMm+.           ``            ");
                                        Console.WriteLine("   /MN`  `NM-                                                       dMNdmmho-                       ");
                                        Console.WriteLine("   mM+    hMo                                                       -hNmo:+hmh.                     ");
                                        Console.WriteLine("  oMd     .Nd                                                        `:yNd-.ms                      ");
                                        Console.WriteLine("`oNN/.`    hNyo:`                                                      `/Nh`.  ``   .-.             ");
                                        Console.WriteLine(" .-yydmhsooydMMNmmmmhssso+++:-                                         `+hdhsyhmNdhsdNNmh:    .::-` ");
                                        Console.WriteLine("     `:ydNMMMMMMMMMMdo----:::-                                           ``./oyddmNMMMMMMNy/. `omNd`");
                                        Console.WriteLine("         `...../ooo+:`                                                           ``.+hMMMMMNd   `:+.");
                                        Console.WriteLine("                                                                                   /yss+//.         ");


                                        Console.WriteLine("O Caçador de Recompensas atira mais rápido, acertando em cheio o Xerife");

                                    }
                                    if (escolha == 1 && escolha2 == 3)
                                    {

                                        Console.WriteLine("        `.hs+                                                                            shd..       ");
                                        Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                        Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                        Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                        Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                        Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                        Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                        Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                        Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                        Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                        Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                        Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                        Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                        Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                        Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                        Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                        Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                        Console.WriteLine("O Caçador de Recompensas efetua o disparo, mas o Xerife rapidamente se esquiva!");
                                    }
                                    if (escolha == 2 && escolha2 == 2)
                                    {
                                        Console.WriteLine("        `.hs+                                                                            shd..       ");
                                        Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                        Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                        Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                        Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                        Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                        Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                        Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                        Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                        Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                        Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                        Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                        Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                        Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                        Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                        Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                        Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                        Console.WriteLine("Os dois caubóis decidem recarregar ao mesmo tempo!");
                                    }


                                    if (escolha == 2 && escolha2 == 1 || escolha == 4 && escolha2 == 1)
                                    {
                                        Console.WriteLine("                                                                                         shd..");
                                        Console.WriteLine("                                                                                      `-mMMd` ");
                                        Console.WriteLine("                                                                           ```    ```../dMMNso- ");
                                        Console.WriteLine("           .                 `                                          -:-/smyhyyhdmmddNMMMMMm. ");
                                        Console.WriteLine("          -h-     .-.       /h+                                              ::..````   oMMMMNNh   ");
                                        Console.WriteLine("         `hmy    -NMd `    -dd`                                                         /MMMMdsN:   ");
                                        Console.WriteLine("          ``:`   -mMNyhhhyydy`                                                          sMMMMd`mh   ");
                                        Console.WriteLine("                .hNMMMMMMy:.                                                            hMMMMN-oN:  ");
                                        Console.WriteLine("               `yMmdNMMMMMm+.                                                          -mMMmMMN/N/  ");
                                        Console.WriteLine("        -:+.--:yMh.`-:smMMMMm:                                                         :MMN.dMMyys  ");
                                        Console.WriteLine("        :ssohhhs+`     `+mMMMN+`                                                       `mMs :NMs`s  ");
                                        Console.WriteLine("            ``           .+mMMMs                                                       `NM-  sMd .  ");
                                        Console.WriteLine("                       -ohmmdNMd                                                       -MN`  `NM/   ");
                                        Console.WriteLine("                     .hmh+:omNh-                                                       oMh    +Mm   ");
                                        Console.WriteLine("                      sm.-dNy:`                                                        dN.     dMo  ");
                                        Console.WriteLine("             .-.   ``  .`hN/`                                                      `:oyNh    `./NNo`");
                                        Console.WriteLine(" `-::.    :hmNNdshdNmhyshdh+`                                         -:+++ossshmmmmNMMdyooshmdyy-. ");
                                        Console.WriteLine("`dNmo` ./yNMMMMMMNmddyo/.``                                           -:::----odMMMMMMMMMMNdy:`     ");
                                        Console.WriteLine(".+:`   dNMMMMMh+.``                                                           `:+ooo/.....`         ");
                                        Console.WriteLine("         .//+ssy/                                                                                   ");
                                        morte = 1;
                                        a = 2;

                                        Console.WriteLine("O Xerife atira mais rápido, acertando em cheio o Caçador de Recompensas!");
                                    }
                                    if (escolha == 3 && escolha2 == 1)
                                    {
                                        Console.WriteLine("        `.hs+                                                                            shd..       ");
                                        Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                        Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                        Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                        Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                        Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                        Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                        Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                        Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                        Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                        Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                        Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                        Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                        Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                        Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                        Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                        Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                        Console.WriteLine("O Xerife efetua o disparo, mas o Caçador de Recompensas rapidamente se esquiva!");

                                    }

                                    if (escolha == 3 && escolha2 == 3)
                                    {
                                        Console.WriteLine("        `.hs+                                                                            shd..       ");
                                        Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                        Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                        Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                        Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                        Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                        Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                        Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                        Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                        Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                        Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                        Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                        Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                        Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                        Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                        Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                        Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                        Console.WriteLine("Os dois caubóis escolhem se esquivar e ninguém atira!");
                                    }

                                    if (escolha == 3 && escolha2 == 2 || escolha == 2 && escolha2 == 3 || escolha == 4 && escolha2 == 4 || escolha == 3 && escolha2 == 4 || escolha == 4 && escolha2 == 3 || escolha == 2 && escolha2 == 4 || escolha == 4 && escolha2 == 2)
                                    {
                                        Console.WriteLine("        `.hs+                                                                            shd..       ");
                                        Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                        Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                        Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                        Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                        Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                        Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                        Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                        Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                        Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                        Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                        Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                        Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                        Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                        Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                        Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                        Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                        Console.WriteLine("Ninguém decide atacar neste turno!");
                                    }

                                    Console.ReadKey();
                                    Console.Clear();
                                    tempus++;
                                    if (tempus >= 10)
                                    {
                                        tempus = 0;
                                        tempus10++;
                                    }
                                    if (tempus10 == 6)
                                    {
                                        a = 3;
                                        morte = 1;
                                    }
                                }
                                while (morte != 1);
                                if (a == 1)
                                {
                                    //PARTE 3 HISTÓRIA DO CAÇADOR DE RECOMPENSAS

                                    morte = 0;
                                    a = 0;
                                    bala = 0;
                                    bala2 = 0;
                                    primeiroturno = 0;
                                    Console.WriteLine("Dia 2, Casarão Abandonado, 12:{0}{1}", tempus10,tempus);
                                    Console.WriteLine("[Caçador de Recompensas] Essa cidade está repleta de idiotas. E eu estou matando cada um deles.");
                                    Console.WriteLine("[Caçador de Recompensas] Preciso ir atrás daquele Esqueleto para vender aquele diamante.");
                                    Console.WriteLine("        ..dhs                                                                                        ");
                                    Console.WriteLine("       `dMMm-`                                                                                      ");
                                    Console.WriteLine("     -osNMMd/..```    ```                                                                           ");
                                    Console.WriteLine("    .mMMMMMNddmmdhyyhyms/-:-                                          `                 .           ");
                                    Console.WriteLine("   hNNMMMMo   ````..::                                              +h/       .-.     -h-          ");
                                    Console.WriteLine("   :NsdMMMM/                                                         `dd-    ` dMN-    ymh`         ");
                                    Console.WriteLine("   hm`dMMMMs                                                          `ydyyhhhyNMm-   `:``          ");
                                    Console.WriteLine("  :No-NMMMMh                                                            .:yMMMMMMNh.                ");
                                    Console.WriteLine("  /N/NMMmMMm-                                                          .+mMMMMMNdmMy`               ");
                                    Console.WriteLine("  syyMMd.NMM:                                                         :mMMMMms:-`.hMy:--.+:-        ");
                                    Console.WriteLine("  s`sMN: sMm`                                                       `+NMMMm+`     `+shhhoss:        ");
                                    Console.WriteLine("  . dMs  -MN`                                                       sMMMm+.           ``            ");
                                    Console.WriteLine("   /MN`  `NM-                                                       dMNdmmho-                       ");
                                    Console.WriteLine("   mM+    hMo                                                       -hNmo:+hmh.                     ");
                                    Console.WriteLine("  oMd     .Nd                                                        `:yNd-.ms                      ");
                                    Console.WriteLine("`oNN/.`    hNyo:`                                                      `/Nh`.  ``   .-.             ");
                                    Console.WriteLine(" .-yydmhsooydMMNmmmmhssso+++:-                                         `+hdhsyhmNdhsdNNmh:    .::-` ");
                                    Console.WriteLine("     `:ydNMMMMMMMMMMdo----:::-                                           ``./oyddmNMMMMMMNy/. `omNd`");
                                    Console.WriteLine("         `...../ooo+:`                                                           ``.+hMMMMMNd   `:+.");
                                    Console.WriteLine("                                                                                   /yss+//.         ");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("Dia 3, Trem do Meio-dia, 11:58");
                                    Console.WriteLine("[Caçador de Recompensas] Ei, Esqueleto! Me dê o diamante logo e eu não terei que usar meu revólver por hoje.");
                                    Console.WriteLine("        `.hs+                                                                            shd..       ");
                                    Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                    Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                    Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                    Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                    Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                    Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                    Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                    Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                    Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                    Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                    Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                    Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                    Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                    Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                    Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                    Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("Dia 3, Trem do Meio dia, 11:59");
                                    Console.WriteLine("[Esqueleto] Não vou deixar esse diamante nas suas mãos. Você não sabe o verdadeiro valor que ele possui.");
                                    Console.WriteLine("[Caçador de Recompensas] Eu irei saber o valor que ele possui assim que eu o vender hoje para um contrabandista. E você não estará vivo para saber quanto ele vale.");
                                    Console.WriteLine("        `.hs+                                                                            shd..       ");
                                    Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                    Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                    Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                    Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                    Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                    Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                    Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                    Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                    Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                    Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                    Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                    Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                    Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                    Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                    Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                    Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                    Console.ReadKey();
                                    Console.Clear();
                                    tempus = 0;
                                    tempus10 = 0;
                                    do
                                    {
                                        Console.WriteLine("Dia 3, Trem do Meio-dia, 12:{0}{1}", tempus10, tempus);
                                        Console.WriteLine("É meio dia.");
                                        Console.WriteLine("        `.hs+                                                                            shd..       ");
                                        Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                        Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                        Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                        Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                        Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                        Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                        Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                        Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                        Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                        Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                        Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                        Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                        Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                        Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                        Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                        Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                        Console.WriteLine("Caçador de Recompensas, faça a sua decisão: (1)Atirar  (2)Recarregar  (3)Esquivar");
                                        escolha = int.Parse(Console.ReadLine());
                                        Console.Clear();



                                        if (escolha == 1)
                                        {
                                            Console.WriteLine("Caçador de Recompensas sacou o seu revólver...");
                                            if (bala < 1)
                                            {
                                                Console.WriteLine("Mas estava sem balas!");
                                                escolha = 4;
                                            }
                                            else
                                            {
                                                Console.WriteLine("E apertou o gatilho!");
                                                bala--;
                                            }
                                        }
                                        else if (escolha == 2)
                                        {
                                            Console.WriteLine("Caçador de Recompensas decidiu colocar uma bala em seu revólver...");
                                            bala++;
                                        }
                                        else if (escolha == 3)
                                        {
                                            Console.WriteLine("Caçador de Recompensas decidiu se esquivar para escapar do tiro...");
                                        }

                                        Random rand = new Random();
                                        escolha2 = rand.Next(1, 3);
                                        if (primeiroturno == 0)
                                        {
                                            Console.WriteLine("Esqueleto decidiu colocar uma bala em seu revólver...");
                                            bala2++;
                                            primeiroturno = 1;
                                            escolha2 = 2;
                                        }
                                        else
                                        {
                                            if (escolha2 == 1)
                                            {
                                                Console.WriteLine("Esqueleto sacou o seu revólver...");
                                                if (bala2 < 1)
                                                {
                                                    Console.WriteLine("Mas estava sem balas!");
                                                    escolha2 = 4;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("E apertou o gatilho!");
                                                    bala2--;
                                                }
                                            }
                                            else if (escolha2 == 2)
                                            {
                                                Console.WriteLine("Esqueleto decidiu colocar uma bala em seu revólver...");
                                                bala2++;
                                            }
                                            else if (escolha2 == 3)
                                            {
                                                Console.WriteLine("Esqueleto decidiu se esquivar para escapar do tiro...");
                                            }

                                        }
                                        if (escolha == 1 && escolha2 == 1)
                                        {
                                            Console.WriteLine("       ..dhs                                                                            shd..       ");
                                            Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                            Console.WriteLine("     -osNMMd/..```    ```                                                  ```    ```../dMMNso-     ");
                                            Console.WriteLine("    .mMMMMMNddmmdhyyhyms/-:-                                            -:-/smyhyyhdmmddNMMMMMm.    ");
                                            Console.WriteLine("    hNNMMMMo   ````..::                                                      ::..````   oMMMMNNh    ");
                                            Console.WriteLine("   :NsdMMMM/                                                                            /MMMMdsN:   ");
                                            Console.WriteLine("   hm`dMMMMs                                                                            sMMMMd`mh   ");
                                            Console.WriteLine("  :No-NMMMMh                                                                            hMMMMN-oN:  ");
                                            Console.WriteLine("  /N/NMMmMMm-                                                                          -mMMmMMN/N/ ");
                                            Console.WriteLine("  syyMMd.NMM:                                                                          :MMN.dMMyys  ");
                                            Console.WriteLine("  s`sMN: sMm`                                                                          `mMs :NMs`s  ");
                                            Console.WriteLine("  . dMs  -MN`                                                                          `NM-  sMd .  ");
                                            Console.WriteLine("   /MN`  `NM-                                                                          -MN`  `NM/  ");
                                            Console.WriteLine("   mM+    hMo                                                                          oMh    +Mm  ");
                                            Console.WriteLine("  oMd     .Nd                                                                          dN.     dMo  ");
                                            Console.WriteLine("`oNN/.`    hNyo:`                                                                  `:oyNh    `./NNo`");
                                            Console.WriteLine(" .-yydmhsooydMMNmmmmhssso+++:-                                        -:+++ossshmmmmNMMdyooshmdyy-. ");
                                            Console.WriteLine("     `:ydNMMMMMMMMMMdo----:::-                                        -:::----odMMMMMMMMMMNdy:`     ");
                                            Console.WriteLine("         `...../ooo+:`                                                        `:+ooo/.....`         ");
                                            Console.WriteLine("Os dois caubóis atiram ao mesmo tempo! Cada bala ricocheteia a outra, que explodem no ar!");

                                        }
                                        if (escolha == 1 && escolha2 == 2 || escolha == 1 && escolha2 == 4)
                                        {

                                            morte = 1;
                                            a = 1;

                                            Console.WriteLine("        ..dhs                                                                                        ");
                                            Console.WriteLine("       `dMMm-`                                                                                      ");
                                            Console.WriteLine("     -osNMMd/..```    ```                                                                           ");
                                            Console.WriteLine("    .mMMMMMNddmmdhyyhyms/-:-                                          `                 .           ");
                                            Console.WriteLine("   hNNMMMMo   ````..::                                              +h/       .-.     -h-          ");
                                            Console.WriteLine("   :NsdMMMM/                                                         `dd-    ` dMN-    ymh`         ");
                                            Console.WriteLine("   hm`dMMMMs                                                          `ydyyhhhyNMm-   `:``          ");
                                            Console.WriteLine("  :No-NMMMMh                                                            .:yMMMMMMNh.                ");
                                            Console.WriteLine("  /N/NMMmMMm-                                                          .+mMMMMMNdmMy`               ");
                                            Console.WriteLine("  syyMMd.NMM:                                                         :mMMMMms:-`.hMy:--.+:-        ");
                                            Console.WriteLine("  s`sMN: sMm`                                                       `+NMMMm+`     `+shhhoss:        ");
                                            Console.WriteLine("  . dMs  -MN`                                                       sMMMm+.           ``            ");
                                            Console.WriteLine("   /MN`  `NM-                                                       dMNdmmho-                       ");
                                            Console.WriteLine("   mM+    hMo                                                       -hNmo:+hmh.                     ");
                                            Console.WriteLine("  oMd     .Nd                                                        `:yNd-.ms                      ");
                                            Console.WriteLine("`oNN/.`    hNyo:`                                                      `/Nh`.  ``   .-.             ");
                                            Console.WriteLine(" .-yydmhsooydMMNmmmmhssso+++:-                                         `+hdhsyhmNdhsdNNmh:    .::-` ");
                                            Console.WriteLine("     `:ydNMMMMMMMMMMdo----:::-                                           ``./oyddmNMMMMMMNy/. `omNd`");
                                            Console.WriteLine("         `...../ooo+:`                                                           ``.+hMMMMMNd   `:+.");
                                            Console.WriteLine("                                                                                   /yss+//.         ");


                                            Console.WriteLine("O Caçador de Recompensas atira mais rápido, acertando em cheio o Esqueleto");

                                        }
                                        if (escolha == 1 && escolha2 == 3)
                                        {

                                            Console.WriteLine("        `.hs+                                                                            shd..       ");
                                            Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                            Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                            Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                            Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                            Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                            Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                            Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                            Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                            Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                            Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                            Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                            Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                            Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                            Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                            Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                            Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                            Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                            Console.WriteLine("O Caçador de Recompensas efetua o disparo, mas o Esqueleto rapidamente se esquiva!");
                                        }
                                        if (escolha == 2 && escolha2 == 2)
                                        {
                                            Console.WriteLine("        `.hs+                                                                            shd..       ");
                                            Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                            Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                            Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                            Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                            Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                            Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                            Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                            Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                            Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                            Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                            Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                            Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                            Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                            Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                            Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                            Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                            Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                            Console.WriteLine("Os dois caubóis decidem recarregar ao mesmo tempo!");
                                        }


                                        if (escolha == 2 && escolha2 == 1 || escolha == 4 && escolha2 == 1)
                                        {
                                            Console.WriteLine("                                                                                         shd..");
                                            Console.WriteLine("                                                                                      `-mMMd` ");
                                            Console.WriteLine("                                                                           ```    ```../dMMNso- ");
                                            Console.WriteLine("           .                 `                                          -:-/smyhyyhdmmddNMMMMMm. ");
                                            Console.WriteLine("          -h-     .-.       /h+                                              ::..````   oMMMMNNh   ");
                                            Console.WriteLine("         `hmy    -NMd `    -dd`                                                         /MMMMdsN:   ");
                                            Console.WriteLine("          ``:`   -mMNyhhhyydy`                                                          sMMMMd`mh   ");
                                            Console.WriteLine("                .hNMMMMMMy:.                                                            hMMMMN-oN:  ");
                                            Console.WriteLine("               `yMmdNMMMMMm+.                                                          -mMMmMMN/N/  ");
                                            Console.WriteLine("        -:+.--:yMh.`-:smMMMMm:                                                         :MMN.dMMyys  ");
                                            Console.WriteLine("        :ssohhhs+`     `+mMMMN+`                                                       `mMs :NMs`s  ");
                                            Console.WriteLine("            ``           .+mMMMs                                                       `NM-  sMd .  ");
                                            Console.WriteLine("                       -ohmmdNMd                                                       -MN`  `NM/   ");
                                            Console.WriteLine("                     .hmh+:omNh-                                                       oMh    +Mm   ");
                                            Console.WriteLine("                      sm.-dNy:`                                                        dN.     dMo  ");
                                            Console.WriteLine("             .-.   ``  .`hN/`                                                      `:oyNh    `./NNo`");
                                            Console.WriteLine(" `-::.    :hmNNdshdNmhyshdh+`                                         -:+++ossshmmmmNMMdyooshmdyy-. ");
                                            Console.WriteLine("`dNmo` ./yNMMMMMMNmddyo/.``                                           -:::----odMMMMMMMMMMNdy:`     ");
                                            Console.WriteLine(".+:`   dNMMMMMh+.``                                                           `:+ooo/.....`         ");
                                            Console.WriteLine("         .//+ssy/                                                                                   ");
                                            morte = 1;
                                            a = 2;

                                            Console.WriteLine("O Esqueleto atira mais rápido, acertando em cheio o Caçador de Recompensas!");
                                        }
                                        if (escolha == 3 && escolha2 == 1)
                                        {
                                            Console.WriteLine("        `.hs+                                                                            shd..       ");
                                            Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                            Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                            Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                            Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                            Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                            Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                            Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                            Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                            Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                            Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                            Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                            Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                            Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                            Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                            Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                            Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                            Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                            Console.WriteLine("O Esqueleto efetua o disparo, mas o Caçador de Recompensas rapidamente se esquiva!");

                                        }

                                        if (escolha == 3 && escolha2 == 3)
                                        {
                                            Console.WriteLine("        `.hs+                                                                            shd..       ");
                                            Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                            Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                            Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                            Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                            Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                            Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                            Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                            Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                            Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                            Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                            Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                            Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                            Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                            Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                            Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                            Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                            Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                            Console.WriteLine("Os dois caubóis escolhem se esquivar e ninguém atira!");
                                        }

                                        if (escolha == 3 && escolha2 == 2 || escolha == 2 && escolha2 == 3 || escolha == 4 && escolha2 == 4 || escolha == 3 && escolha2 == 4 || escolha == 4 && escolha2 == 3 || escolha == 2 && escolha2 == 4 || escolha == 4 && escolha2 == 2)
                                        {
                                            Console.WriteLine("        `.hs+                                                                            shd..       ");
                                            Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                            Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                            Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                            Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                            Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                            Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                            Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                            Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                            Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                            Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                            Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                            Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                            Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                            Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                            Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                            Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                            Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                            Console.WriteLine("Ninguém decide atacar neste turno!");
                                        }

                                        Console.ReadKey();
                                        Console.Clear();
                                        tempus++;
                                        if (tempus >= 10)
                                        {
                                            tempus = 0;
                                            tempus10++;
                                        }
                                        if (tempus10 == 6)
                                        {
                                            a = 3;
                                            morte = 1;
                                        }
                                    }
                                    while (morte != 1);
                                    if (a == 1)
                                    {
                                        Console.WriteLine("Dia 3, Trem do Meio-dia, 12:{0}{1}",tempus10,tempus);
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.Clear();
                                        Console.WriteLine("              MM                                              MM,");
                                        Console.WriteLine("            O8M~                                               M M");
                                        Console.WriteLine("          7N :M,                                               MN  M=");
                                        Console.WriteLine("        ?M   M M                                               MM    8N ");
                                        Console.WriteLine("      =M    M.  M:                                            MIMMMD   :M");
                                        Console.WriteLine("    :M      M     M+                                        .M  ,+  :MMM? M.");
                                        Console.WriteLine("   M.      M        M=                                     MI    M      +MMMM");
                                        Console.WriteLine(" M,       .7           MM,                             OMZ       M           M");
                                        Console.WriteLine("M         M              :MM$MMMM$=,         ,=$MMMM.            7.           M");
                                        Console.WriteLine("+        M             MM+  M                    MM MM            M           O");
                                        Console.WriteLine("        M          MM        8                  M      $M         M.           M");
                                        Console.WriteLine("       +O        MM           M                M?        M~       ~O           I");
                                        Console.WriteLine("M      M      :MM              M              MM          $M       M          M ");
                                        Console.WriteLine("  M  M ~MN                       M          M.                 MM   M      M   ");
                                        Console.WriteLine("   MNMMM                          M        MM                   $M  M     M    ");
                                        Console.WriteLine("    M=                            I+      MM                      MMM=  M      ");
                                        Console.WriteLine("       MI$M=                        M    M.                     :MMN~          ");
                                        Console.WriteLine("         M?  MM?                     M  M7                  ~MM  :M            ");
                                        Console.WriteLine("           M    OMM+                 D~~M                7MM    M~             ");
                                        Console.WriteLine("             M      :MMMM~            MM           ~MMMM      ,M               ");
                                        Console.WriteLine("               M      M:   ~$MMMMMMMMMMMMMMMMMMI.    =8      M                 ");
                                        Console.WriteLine("                .M     ZM             M,            $7     .=             ");
                                        Console.WriteLine("                    M$    M=           M          M,    D+       ");
                                        Console.WriteLine("                        M    M         M        M=   D?          ");
                                        Console.WriteLine("                          M   M        M       M,  .M          ");
                                        Console.WriteLine("                            M  :M      M      M.  M        ");
                                        Console.WriteLine("                             .M  M     Z     M  O7      ");
                                        Console.WriteLine("                               M7 M    =:   M, M      ");
                                        Console.WriteLine("                                 MIOO   D  M.Z7 ");
                                        Console.WriteLine("                                   M=M  M M M   ");
                                        Console.WriteLine("                                     MM:MMM       ");
                                        Console.WriteLine("                                        :      ");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("O maquinista avisa aos passageiros que o trem chegou à cidade de Silverneck");
                                        //imagem de trem aqui
                                        Console.WriteLine("O Caçador de Recompensas volta para a cidade com o diamante de Silverneck.");
                                        //imagem de um diamante ou da delegacia talvez
                                        Console.WriteLine("Ele o vende para o contrabandista, garantindo-lhe dinheiro e provisões por um bom tempo.");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                            }
                            Console.WriteLine(" _______  ___   __   __    ______   _______        ___  _______  _______  _______");
                            Console.WriteLine("|       ||   | |  |_|  |  |      | |       |      |   ||       ||       ||       |");
                            Console.WriteLine("|    ___||   | |       |  |  _    ||    ___|      |   ||   _   ||    ___||   _   |");
                            Console.WriteLine("|   |___ |   | |       |  | | |   ||   |___       |   ||  | |  ||   | __ |  | |  |");
                            Console.WriteLine("|    ___||   | |       |  | |_|   ||    ___|   ___|   ||  |_|  ||   ||  ||  |_|  |");
                            Console.WriteLine("|   |    |   | | ||_|| |  |       ||   |___   |       ||       ||   |_| ||       |");
                            Console.WriteLine("|___|    |___| |_|   |_|  |______| |_______|  |_______||_______||_______||_______|");
                            Console.WriteLine("           _______  _______  _     _  _______  _______  __   __                  ");
                            Console.WriteLine("          |     __||       || | _ | ||  _    ||       ||  | |  |                 ");
                            Console.WriteLine("          |    |   |   _   || || || || |_|   ||   _   ||  |_|  |                  ");
                            Console.WriteLine("          |    |   |  | |  ||       ||       ||  | |  ||       |                  ");
                            Console.WriteLine("          |    |   |  |_|  ||       ||  _   | |  |_|  ||_     _|                  ");
                            Console.WriteLine("          |    |__ |       ||   _   || |_|   ||       |  |   |                    ");
                            Console.WriteLine("          |_______||_______||__| |__||_______||_______|  |___|                    ");
                            if (a == 3)
                                Console.WriteLine("Tempo esgotado! Você perdeu!");
                            Console.ReadKey();
                        }
                        ////////////PARTE DO LADRÃO 
                        else if (pers == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Dia 1, Banco de Silverneck, 11:58");
                            Console.WriteLine("[Ladrão] Todo mundo no chão ou eu atiro!");
                            Console.WriteLine("[Ladrão] Hahaha, eu sempre quis falar isso.");
                            Console.WriteLine("[Caçador de Recompensas] Você não vai pra lugar nenhum, amigo.");
                            Console.WriteLine("        `.hs+                                                                            shd..       ");
                            Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                            Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                            Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                            Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                            Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                            Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                            Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                            Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                            Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                            Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                            Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                            Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                            Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                            Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                            Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                            Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                            Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine("Dia 1, Banco de Silverneck, 11:59");
                            Console.WriteLine("[Ladrão] Ei! Ninguém aponta uma arma na minha cara e sai vivo.");
                            Console.WriteLine("[Caçador de Recompensas] Então prepare-se para o seu velório.");
                            Console.WriteLine("        `.hs+                                                                            shd..       ");
                            Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                            Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                            Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                            Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                            Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                            Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                            Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                            Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                            Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                            Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                            Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                            Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                            Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                            Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                            Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                            Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                            Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                            Console.ReadKey();
                            Console.Clear();
                            do
                            {
                                Console.WriteLine("Dia 1, Banco de Silverneck, 12:{0}{1}", tempus10, tempus);
                                Console.WriteLine("É meio dia.");
                                Console.WriteLine("        `.hs+                                                                            shd..       ");
                                Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                Console.WriteLine("Ladrão, faça a sua decisão: (1)Atirar  (2)Recarregar  (3)Esquivar");
                                escolha = int.Parse(Console.ReadLine());
                                Console.Clear();



                                if (escolha == 1)
                                {
                                    Console.WriteLine("Ladrão sacou o seu revólver...");
                                    if (bala < 1)
                                    {
                                        Console.WriteLine("Mas estava sem balas!");
                                        escolha = 4;
                                    }
                                    else
                                    {
                                        Console.WriteLine("E apertou o gatilho!");
                                        bala--;
                                    }
                                }
                                else if (escolha == 2)
                                {
                                    Console.WriteLine("Ladrão decidiu colocar uma bala em seu revólver...");
                                    bala++;
                                }
                                else if (escolha == 3)
                                {
                                    Console.WriteLine("Ladrão decidiu se esquivar para escapar do tiro...");
                                }

                                Random rand = new Random();


                                if (primeiroturno == 0)
                                {
                                    Console.WriteLine("Caçador de Recompensas decidiu colocar uma bala em seu revólver...");
                                    bala2++;
                                    primeiroturno = 1;
                                    escolha2 = 2;
                                }
                                else
                                {
                                    if (bala2 > 0)
                                    {
                                        if (bala > 0)
                                        {
                                            int auxescolha;
                                            auxescolha = rand.Next(1, 3);
                                            if (auxescolha == 1)
                                            {
                                                escolha2 = 1;
                                            }
                                            else
                                                escolha2 = 3;

                                        }
                                        else
                                        {
                                            escolha2 = 1;
                                        }
                                    }
                                    else
                                    {
                                        escolha2 = rand.Next(2, 4);
                                    }

                                    if (escolha2 == 1)
                                    {
                                        Console.WriteLine("Caçador de Recompensas sacou o seu revólver...");
                                        if (bala2 < 1)
                                        {
                                            Console.WriteLine("Mas estava sem balas!");
                                            escolha2 = 4;
                                        }
                                        else
                                        {
                                            Console.WriteLine("E apertou o gatilho!");
                                            bala2--;
                                        }
                                    }
                                    else if (escolha2 == 2)
                                    {
                                        Console.WriteLine("Caçador de Recompensas decidiu colocar uma bala em seu revólver...");
                                        bala2++;
                                    }
                                    else if (escolha2 == 3)
                                    {
                                        Console.WriteLine("Caçador de Recompensas decidiu se esquivar para escapar do tiro...");
                                    }

                                }

                                if (escolha == 1 && escolha2 == 1)
                                {
                                    Console.WriteLine("       ..dhs                                                                            shd..       ");
                                    Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                    Console.WriteLine("     -osNMMd/..```    ```                                                  ```    ```../dMMNso-     ");
                                    Console.WriteLine("    .mMMMMMNddmmdhyyhyms/-:-                                            -:-/smyhyyhdmmddNMMMMMm.    ");
                                    Console.WriteLine("    hNNMMMMo   ````..::                                                      ::..````   oMMMMNNh    ");
                                    Console.WriteLine("   :NsdMMMM/                                                                            /MMMMdsN:   ");
                                    Console.WriteLine("   hm`dMMMMs                                                                            sMMMMd`mh   ");
                                    Console.WriteLine("  :No-NMMMMh                                                                            hMMMMN-oN:  ");
                                    Console.WriteLine("  /N/NMMmMMm-                                                                          -mMMmMMN/N/ ");
                                    Console.WriteLine("  syyMMd.NMM:                                                                          :MMN.dMMyys  ");
                                    Console.WriteLine("  s`sMN: sMm`                                                                          `mMs :NMs`s  ");
                                    Console.WriteLine("  . dMs  -MN`                                                                          `NM-  sMd .  ");
                                    Console.WriteLine("   /MN`  `NM-                                                                          -MN`  `NM/  ");
                                    Console.WriteLine("   mM+    hMo                                                                          oMh    +Mm  ");
                                    Console.WriteLine("  oMd     .Nd                                                                          dN.     dMo  ");
                                    Console.WriteLine("`oNN/.`    hNyo:`                                                                  `:oyNh    `./NNo`");
                                    Console.WriteLine(" .-yydmhsooydMMNmmmmhssso+++:-                                        -:+++ossshmmmmNMMdyooshmdyy-. ");
                                    Console.WriteLine("     `:ydNMMMMMMMMMMdo----:::-                                        -:::----odMMMMMMMMMMNdy:`     ");
                                    Console.WriteLine("         `...../ooo+:`                                                        `:+ooo/.....`         ");
                                    Console.WriteLine("Os dois caubóis atiram ao mesmo tempo! Cada bala ricocheteia a outra, que explodem no ar!");

                                }
                                if (escolha == 1 && escolha2 == 2 || escolha == 1 && escolha2 == 4)
                                {

                                    morte = 1;
                                    a = 1;

                                    Console.WriteLine("        ..dhs                                                                                        ");
                                    Console.WriteLine("       `dMMm-`                                                                                      ");
                                    Console.WriteLine("     -osNMMd/..```    ```                                                                           ");
                                    Console.WriteLine("    .mMMMMMNddmmdhyyhyms/-:-                                          `                 .           ");
                                    Console.WriteLine("   hNNMMMMo   ````..::                                              +h/       .-.     -h-          ");
                                    Console.WriteLine("   :NsdMMMM/                                                         `dd-    ` dMN-    ymh`         ");
                                    Console.WriteLine("   hm`dMMMMs                                                          `ydyyhhhyNMm-   `:``          ");
                                    Console.WriteLine("  :No-NMMMMh                                                            .:yMMMMMMNh.                ");
                                    Console.WriteLine("  /N/NMMmMMm-                                                          .+mMMMMMNdmMy`               ");
                                    Console.WriteLine("  syyMMd.NMM:                                                         :mMMMMms:-`.hMy:--.+:-        ");
                                    Console.WriteLine("  s`sMN: sMm`                                                       `+NMMMm+`     `+shhhoss:        ");
                                    Console.WriteLine("  . dMs  -MN`                                                       sMMMm+.           ``            ");
                                    Console.WriteLine("   /MN`  `NM-                                                       dMNdmmho-                       ");
                                    Console.WriteLine("   mM+    hMo                                                       -hNmo:+hmh.                     ");
                                    Console.WriteLine("  oMd     .Nd                                                        `:yNd-.ms                      ");
                                    Console.WriteLine("`oNN/.`    hNyo:`                                                      `/Nh`.  ``   .-.             ");
                                    Console.WriteLine(" .-yydmhsooydMMNmmmmhssso+++:-                                         `+hdhsyhmNdhsdNNmh:    .::-` ");
                                    Console.WriteLine("     `:ydNMMMMMMMMMMdo----:::-                                           ``./oyddmNMMMMMMNy/. `omNd`");
                                    Console.WriteLine("         `...../ooo+:`                                                           ``.+hMMMMMNd   `:+.");
                                    Console.WriteLine("                                                                                   /yss+//.         ");


                                    Console.WriteLine("O Ladrão atira mais rápido, acertando em cheio o Caçador de Recompensas");

                                }
                                if (escolha == 1 && escolha2 == 3)
                                {

                                    Console.WriteLine("        `.hs+                                                                            shd..       ");
                                    Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                    Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                    Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                    Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                    Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                    Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                    Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                    Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                    Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                    Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                    Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                    Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                    Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                    Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                    Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                    Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                    Console.WriteLine("O Ladrão efetua o disparo, mas o Caçador de Recompensas rapidamente se esquiva!");
                                }
                                if (escolha == 2 && escolha2 == 2)
                                {
                                    Console.WriteLine("        `.hs+                                                                            shd..       ");
                                    Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                    Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                    Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                    Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                    Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                    Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                    Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                    Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                    Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                    Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                    Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                    Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                    Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                    Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                    Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                    Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                    Console.WriteLine("Os dois caubóis decidem recarregar ao mesmo tempo!");
                                }


                                if (escolha == 2 && escolha2 == 1 || escolha == 4 && escolha2 == 1)
                                {
                                    Console.WriteLine("                                                                                         shd..");
                                    Console.WriteLine("                                                                                      `-mMMd` ");
                                    Console.WriteLine("                                                                           ```    ```../dMMNso- ");
                                    Console.WriteLine("           .                 `                                          -:-/smyhyyhdmmddNMMMMMm. ");
                                    Console.WriteLine("          -h-     .-.       /h+                                              ::..````   oMMMMNNh   ");
                                    Console.WriteLine("         `hmy    -NMd `    -dd`                                                         /MMMMdsN:   ");
                                    Console.WriteLine("          ``:`   -mMNyhhhyydy`                                                          sMMMMd`mh   ");
                                    Console.WriteLine("                .hNMMMMMMy:.                                                            hMMMMN-oN:  ");
                                    Console.WriteLine("               `yMmdNMMMMMm+.                                                          -mMMmMMN/N/  ");
                                    Console.WriteLine("        -:+.--:yMh.`-:smMMMMm:                                                         :MMN.dMMyys  ");
                                    Console.WriteLine("        :ssohhhs+`     `+mMMMN+`                                                       `mMs :NMs`s  ");
                                    Console.WriteLine("            ``           .+mMMMs                                                       `NM-  sMd .  ");
                                    Console.WriteLine("                       -ohmmdNMd                                                       -MN`  `NM/   ");
                                    Console.WriteLine("                     .hmh+:omNh-                                                       oMh    +Mm   ");
                                    Console.WriteLine("                      sm.-dNy:`                                                        dN.     dMo  ");
                                    Console.WriteLine("             .-.   ``  .`hN/`                                                      `:oyNh    `./NNo`");
                                    Console.WriteLine(" `-::.    :hmNNdshdNmhyshdh+`                                         -:+++ossshmmmmNMMdyooshmdyy-. ");
                                    Console.WriteLine("`dNmo` ./yNMMMMMMNmddyo/.``                                           -:::----odMMMMMMMMMMNdy:`     ");
                                    Console.WriteLine(".+:`   dNMMMMMh+.``                                                           `:+ooo/.....`         ");
                                    Console.WriteLine("         .//+ssy/                                                                                   ");

                                    morte = 1;
                                    a = 2;

                                    Console.WriteLine("O Caçador de Recompensas atira mais rápido, acertando em cheio o Ladrão!");
                                }
                                if (escolha == 3 && escolha2 == 1)
                                {
                                    Console.WriteLine("        `.hs+                                                                            shd..       ");
                                    Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                    Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                    Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                    Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                    Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                    Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                    Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                    Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                    Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                    Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                    Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                    Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                    Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                    Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                    Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                    Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                    Console.WriteLine("O Caçador de Recompensas efetua o disparo, mas o Ladrão rapidamente se esquiva!");

                                }

                                if (escolha == 3 && escolha2 == 3)
                                {
                                    Console.WriteLine("        `.hs+                                                                            shd..       ");
                                    Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                    Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                    Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                    Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                    Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                    Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                    Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                    Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                    Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                    Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                    Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                    Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                    Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                    Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                    Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                    Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                    Console.WriteLine("Os dois caubóis escolhem se esquivar e ninguém atira!");
                                }

                                if(escolha == 3 && escolha2 == 2 || escolha == 2 && escolha2 == 3 || escolha == 4 && escolha2 == 4 || escolha == 3 && escolha2 == 4 || escolha == 4 && escolha2 == 3 || escolha == 2 && escolha2 == 4 || escolha == 4 && escolha2 == 2)
                                    {
                                    Console.WriteLine("        `.hs+                                                                            shd..       ");
                                    Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                    Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                    Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                    Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                    Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                    Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                    Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                    Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                    Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                    Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                    Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                    Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                    Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                    Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                    Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                    Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                    Console.WriteLine("Ninguém decide atacar neste turno!");
                                }

                                Console.ReadKey();
                                Console.Clear();
                                tempus++;
                                if (tempus >= 10)
                                {
                                    tempus = 0;
                                    tempus10++;
                                }
                                if (tempus10 == 6)
                                {
                                    a = 3;
                                    morte = 1;
                                }
                            }
                            while (morte != 1);

                            if (a == 1)
                            {
                                // PARTE 2 LADRÃO
                                morte = 0;
                                a = 0;
                                bala = 0;
                                bala2 = 0;
                                primeiroturno = 0;

                                Console.WriteLine("Dia 1, Banco de Silverneck, 12:{0}{1}", tempus10, tempus);
                                Console.WriteLine("[Ladrão] O quê?! Sem dinheiro? O Esqueleto roubou esse banco ontem?");
                                Console.WriteLine("[Ladrão] Não tem problema. Eu conheço um lugar que tem algo bem mais valioso nessa cidade.");
                                Console.WriteLine("        ..dhs                                                                                        ");
                                Console.WriteLine("       `dMMm-`                                                                                      ");
                                Console.WriteLine("     -osNMMd/..```    ```                                                                           ");
                                Console.WriteLine("    .mMMMMMNddmmdhyyhyms/-:-                                          `                 .           ");
                                Console.WriteLine("   hNNMMMMo   ````..::                                              +h/       .-.     -h-          ");
                                Console.WriteLine("   :NsdMMMM/                                                         `dd-    ` dMN-    ymh`         ");
                                Console.WriteLine("   hm`dMMMMs                                                          `ydyyhhhyNMm-   `:``          ");
                                Console.WriteLine("  :No-NMMMMh                                                            .:yMMMMMMNh.                ");
                                Console.WriteLine("  /N/NMMmMMm-                                                          .+mMMMMMNdmMy`               ");
                                Console.WriteLine("  syyMMd.NMM:                                                         :mMMMMms:-`.hMy:--.+:-        ");
                                Console.WriteLine("  s`sMN: sMm`                                                       `+NMMMm+`     `+shhhoss:        ");
                                Console.WriteLine("  . dMs  -MN`                                                       sMMMm+.           ``            ");
                                Console.WriteLine("   /MN`  `NM-                                                       dMNdmmho-                       ");
                                Console.WriteLine("   mM+    hMo                                                       -hNmo:+hmh.                     ");
                                Console.WriteLine("  oMd     .Nd                                                        `:yNd-.ms                      ");
                                Console.WriteLine("`oNN/.`    hNyo:`                                                      `/Nh`.  ``   .-.             ");
                                Console.WriteLine(" .-yydmhsooydMMNmmmmhssso+++:-                                         `+hdhsyhmNdhsdNNmh:    .::-` ");
                                Console.WriteLine("     `:ydNMMMMMMMMMMdo----:::-                                           ``./oyddmNMMMMMMNy/. `omNd`");
                                Console.WriteLine("         `...../ooo+:`                                                           ``.+hMMMMMNd   `:+.");
                                Console.WriteLine("                                                                                   /yss+//.         ");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("Dia 2, Delegacia, 11:58");
                                Console.WriteLine("[Ladrão] Aí Xerife, vai passando o Diamante de Silverneck");
                                Console.WriteLine("[Xerife] Chegou tarde. O Esqueleto acabou de passar por aqui.");
                                Console.WriteLine("        `.hs+                                                                            shd..       ");
                                Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                Console.ReadKey();
                                Console.Clear();
                                Console.WriteLine("Dia 2, Delegacia, 11:59");
                                Console.WriteLine("[Ladrão] O quê!? Maldito Esqueleto. Eu ainda vou acabar com ele.");
                                Console.WriteLine("[Xerife] Ei caubói, acho que acabou de entrar em uma delegacia sendo um dos criminosos mais procurados do Oeste.");
                                Console.WriteLine("[Ladrão] ...");
                                Console.WriteLine("        `.hs+                                                                            shd..       ");
                                Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                Console.ReadKey();
                                Console.Clear();
                                tempus = 0;
                                tempus10 = 0;
                                do
                                {
                                    Console.WriteLine("Dia 2, Delegacia, 12:{0}{1}", tempus10, tempus);
                                    Console.WriteLine("É meio dia.");
                                    Console.WriteLine("        `.hs+                                                                            shd..       ");
                                    Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                    Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                    Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                    Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                    Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                    Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                    Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                    Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                    Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                    Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                    Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                    Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                    Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                    Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                    Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                    Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                    Console.WriteLine("Ladrão, faça a sua decisão: (1)Atirar  (2)Recarregar  (3)Esquivar");
                                    escolha = int.Parse(Console.ReadLine());
                                    Console.Clear();



                                    if (escolha == 1)
                                    {
                                        Console.WriteLine("Ladrão sacou o seu revólver...");
                                        if (bala < 1)
                                        {
                                            Console.WriteLine("Mas estava sem balas!");
                                            escolha = 4;
                                        }
                                        else
                                        {
                                            Console.WriteLine("E apertou o gatilho!");
                                            bala++;
                                        }
                                    }
                                    else if (escolha == 2)
                                    {
                                        Console.WriteLine("Ladrão decidiu colocar uma bala em seu revólver...");
                                        bala++;
                                    }
                                    else if (escolha == 3)
                                    {
                                        Console.WriteLine("Ladrão decidiu se esquivar para escapar do tiro...");
                                    }

                                    Random rand = new Random();
                                    escolha2 = rand.Next(1, 3);
                                    if (primeiroturno == 0)
                                    {
                                        Console.WriteLine("Xerife decidiu colocar uma bala em seu revólver...");
                                        bala2++;
                                        primeiroturno = 1;
                                        escolha2 = 2;
                                    }
                                    else
                                    {
                                        if (escolha2 == 1)
                                        {
                                            Console.WriteLine("Xerife sacou o seu revólver...");
                                            if (bala2 < 1)
                                            {
                                                Console.WriteLine("Mas estava sem balas!");
                                                escolha2 = 4;
                                            }
                                            else
                                            {
                                                Console.WriteLine("E apertou o gatilho!");
                                                bala2--;
                                            }
                                        }
                                        else if (escolha2 == 2)
                                        {
                                            Console.WriteLine("Xerife decidiu colocar uma bala em seu revólver...");
                                            bala2++;
                                        }
                                        else if (escolha2 == 3)
                                        {
                                            Console.WriteLine("Xerife decidiu se esquivar para escapar do tiro...");
                                        }

                                    }
                                    if (escolha == 1 && escolha2 == 1)
                                    {
                                        Console.WriteLine("       ..dhs                                                                            shd..       ");
                                        Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                        Console.WriteLine("     -osNMMd/..```    ```                                                  ```    ```../dMMNso-     ");
                                        Console.WriteLine("    .mMMMMMNddmmdhyyhyms/-:-                                            -:-/smyhyyhdmmddNMMMMMm.    ");
                                        Console.WriteLine("    hNNMMMMo   ````..::                                                      ::..````   oMMMMNNh    ");
                                        Console.WriteLine("   :NsdMMMM/                                                                            /MMMMdsN:   ");
                                        Console.WriteLine("   hm`dMMMMs                                                                            sMMMMd`mh   ");
                                        Console.WriteLine("  :No-NMMMMh                                                                            hMMMMN-oN:  ");
                                        Console.WriteLine("  /N/NMMmMMm-                                                                          -mMMmMMN/N/ ");
                                        Console.WriteLine("  syyMMd.NMM:                                                                          :MMN.dMMyys  ");
                                        Console.WriteLine("  s`sMN: sMm`                                                                          `mMs :NMs`s  ");
                                        Console.WriteLine("  . dMs  -MN`                                                                          `NM-  sMd .  ");
                                        Console.WriteLine("   /MN`  `NM-                                                                          -MN`  `NM/  ");
                                        Console.WriteLine("   mM+    hMo                                                                          oMh    +Mm  ");
                                        Console.WriteLine("  oMd     .Nd                                                                          dN.     dMo  ");
                                        Console.WriteLine("`oNN/.`    hNyo:`                                                                  `:oyNh    `./NNo`");
                                        Console.WriteLine(" .-yydmhsooydMMNmmmmhssso+++:-                                        -:+++ossshmmmmNMMdyooshmdyy-. ");
                                        Console.WriteLine("     `:ydNMMMMMMMMMMdo----:::-                                        -:::----odMMMMMMMMMMNdy:`     ");
                                        Console.WriteLine("         `...../ooo+:`                                                        `:+ooo/.....`         ");
                                        Console.WriteLine("Os dois caubóis atiram ao mesmo tempo! Cada bala ricocheteia a outra, que explodem no ar!");

                                    }
                                    if (escolha == 1 && escolha2 == 2 || escolha == 1 && escolha2 == 4)
                                    {

                                        morte = 1;
                                        a = 1;

                                        Console.WriteLine("        ..dhs                                                                                        ");
                                        Console.WriteLine("       `dMMm-`                                                                                      ");
                                        Console.WriteLine("     -osNMMd/..```    ```                                                                           ");
                                        Console.WriteLine("    .mMMMMMNddmmdhyyhyms/-:-                                          `                 .           ");
                                        Console.WriteLine("   hNNMMMMo   ````..::                                              +h/       .-.     -h-          ");
                                        Console.WriteLine("   :NsdMMMM/                                                         `dd-    ` dMN-    ymh`         ");
                                        Console.WriteLine("   hm`dMMMMs                                                          `ydyyhhhyNMm-   `:``          ");
                                        Console.WriteLine("  :No-NMMMMh                                                            .:yMMMMMMNh.                ");
                                        Console.WriteLine("  /N/NMMmMMm-                                                          .+mMMMMMNdmMy`               ");
                                        Console.WriteLine("  syyMMd.NMM:                                                         :mMMMMms:-`.hMy:--.+:-        ");
                                        Console.WriteLine("  s`sMN: sMm`                                                       `+NMMMm+`     `+shhhoss:        ");
                                        Console.WriteLine("  . dMs  -MN`                                                       sMMMm+.           ``            ");
                                        Console.WriteLine("   /MN`  `NM-                                                       dMNdmmho-                       ");
                                        Console.WriteLine("   mM+    hMo                                                       -hNmo:+hmh.                     ");
                                        Console.WriteLine("  oMd     .Nd                                                        `:yNd-.ms                      ");
                                        Console.WriteLine("`oNN/.`    hNyo:`                                                      `/Nh`.  ``   .-.             ");
                                        Console.WriteLine(" .-yydmhsooydMMNmmmmhssso+++:-                                         `+hdhsyhmNdhsdNNmh:    .::-` ");
                                        Console.WriteLine("     `:ydNMMMMMMMMMMdo----:::-                                           ``./oyddmNMMMMMMNy/. `omNd`");
                                        Console.WriteLine("         `...../ooo+:`                                                           ``.+hMMMMMNd   `:+.");
                                        Console.WriteLine("                                                                                   /yss+//.         ");


                                        Console.WriteLine("O Ladrão atira mais rápido, acertando em cheio o Xerife");

                                    }
                                    if (escolha == 1 && escolha2 == 3)
                                    {

                                        Console.WriteLine("        `.hs+                                                                            shd..       ");
                                        Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                        Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                        Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                        Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                        Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                        Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                        Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                        Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                        Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                        Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                        Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                        Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                        Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                        Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                        Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                        Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                        Console.WriteLine("O Ladrão efetua o disparo, mas o Xerife rapidamente se esquiva!");
                                    }
                                    if (escolha == 2 && escolha2 == 2)
                                    {
                                        Console.WriteLine("        `.hs+                                                                            shd..       ");
                                        Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                        Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                        Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                        Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                        Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                        Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                        Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                        Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                        Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                        Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                        Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                        Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                        Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                        Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                        Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                        Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                        Console.WriteLine("Os dois caubóis decidem recarregar ao mesmo tempo!");
                                    }


                                    if (escolha == 2 && escolha2 == 1 || escolha == 4 && escolha2 == 1)
                                    {
                                        Console.WriteLine("                                                                                         shd..");
                                        Console.WriteLine("                                                                                      `-mMMd` ");
                                        Console.WriteLine("                                                                           ```    ```../dMMNso- ");
                                        Console.WriteLine("           .                 `                                          -:-/smyhyyhdmmddNMMMMMm. ");
                                        Console.WriteLine("          -h-     .-.       /h+                                              ::..````   oMMMMNNh   ");
                                        Console.WriteLine("         `hmy    -NMd `    -dd`                                                         /MMMMdsN:   ");
                                        Console.WriteLine("          ``:`   -mMNyhhhyydy`                                                          sMMMMd`mh   ");
                                        Console.WriteLine("                .hNMMMMMMy:.                                                            hMMMMN-oN:  ");
                                        Console.WriteLine("               `yMmdNMMMMMm+.                                                          -mMMmMMN/N/  ");
                                        Console.WriteLine("        -:+.--:yMh.`-:smMMMMm:                                                         :MMN.dMMyys  ");
                                        Console.WriteLine("        :ssohhhs+`     `+mMMMN+`                                                       `mMs :NMs`s  ");
                                        Console.WriteLine("            ``           .+mMMMs                                                       `NM-  sMd .  ");
                                        Console.WriteLine("                       -ohmmdNMd                                                       -MN`  `NM/   ");
                                        Console.WriteLine("                     .hmh+:omNh-                                                       oMh    +Mm   ");
                                        Console.WriteLine("                      sm.-dNy:`                                                        dN.     dMo  ");
                                        Console.WriteLine("             .-.   ``  .`hN/`                                                      `:oyNh    `./NNo`");
                                        Console.WriteLine(" `-::.    :hmNNdshdNmhyshdh+`                                         -:+++ossshmmmmNMMdyooshmdyy-. ");
                                        Console.WriteLine("`dNmo` ./yNMMMMMMNmddyo/.``                                           -:::----odMMMMMMMMMMNdy:`     ");
                                        Console.WriteLine(".+:`   dNMMMMMh+.``                                                           `:+ooo/.....`         ");
                                        Console.WriteLine("         .//+ssy/                                                                                   ");
                                        morte = 1;
                                        a = 2;

                                        Console.WriteLine("O Xerife atira mais rápido, acertando em cheio o Ladrão!");
                                    }
                                    if (escolha == 3 && escolha2 == 1)
                                    {
                                        Console.WriteLine("        `.hs+                                                                            shd..       ");
                                        Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                        Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                        Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                        Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                        Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                        Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                        Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                        Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                        Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                        Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                        Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                        Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                        Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                        Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                        Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                        Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                        Console.WriteLine("O Xerife efetua o disparo, mas o Ladrão rapidamente se esquiva!");

                                    }

                                    if (escolha == 3 && escolha2 == 3)
                                    {
                                        Console.WriteLine("        `.hs+                                                                            shd..       ");
                                        Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                        Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                        Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                        Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                        Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                        Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                        Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                        Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                        Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                        Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                        Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                        Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                        Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                        Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                        Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                        Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                        Console.WriteLine("Os dois caubóis escolhem se esquivar e ninguém atira!");
                                    }

                                    if (escolha == 3 && escolha2 == 2 || escolha == 2 && escolha2 == 3 || escolha == 4 && escolha2 == 4 || escolha == 3 && escolha2 == 4 || escolha == 4 && escolha2 == 3 || escolha == 2 && escolha2 == 4 || escolha == 4 && escolha2 == 2)
                                        {
                                        Console.WriteLine("        `.hs+                                                                            shd..       ");
                                        Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                        Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                        Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                        Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                        Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                        Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                        Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                        Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                        Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                        Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                        Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                        Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                        Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                        Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                        Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                        Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                        Console.WriteLine("Ninguém decide atacar neste turno!");
                                    }

                                    Console.ReadKey();
                                    Console.Clear();
                                    tempus++;
                                    if (tempus >= 10)
                                    {
                                        tempus = 0;
                                        tempus10++;
                                    }
                                    if (tempus10 == 6)
                                    {
                                        a = 3;
                                        morte = 1;
                                    }
                                }
                                while (morte != 1);
                                //PARTE 3 HISTÓRIA DO CAÇADOR DE RECOMPENSAS
                                if (a == 1)
                                {
                                    morte = 0;
                                    a = 0;
                                    bala = 0;
                                    bala2 = 0;
                                    primeiroturno = 0;
                                    Console.WriteLine("Dia 2, Delegacia, 12:{1}{0}", tempus10, tempus);
                                    Console.WriteLine("[Ladrão] Essa foi por pouco. Agora, eu preciso procurar pelo Esqueleto.");
                                    Console.WriteLine("[Ladrão] Ei, o que é isso no seu bolso, Seu Delegado? Uma passagem no trem do meio-dia? Eu adoro passear de trem.");
                                    Console.WriteLine("        ..dhs                                                                                        ");
                                    Console.WriteLine("       `dMMm-`                                                                                      ");
                                    Console.WriteLine("     -osNMMd/..```    ```                                                                           ");
                                    Console.WriteLine("    .mMMMMMNddmmdhyyhyms/-:-                                          `                 .           ");
                                    Console.WriteLine("   hNNMMMMo   ````..::                                              +h/       .-.     -h-          ");
                                    Console.WriteLine("   :NsdMMMM/                                                         `dd-    ` dMN-    ymh`         ");
                                    Console.WriteLine("   hm`dMMMMs                                                          `ydyyhhhyNMm-   `:``          ");
                                    Console.WriteLine("  :No-NMMMMh                                                            .:yMMMMMMNh.                ");
                                    Console.WriteLine("  /N/NMMmMMm-                                                          .+mMMMMMNdmMy`               ");
                                    Console.WriteLine("  syyMMd.NMM:                                                         :mMMMMms:-`.hMy:--.+:-        ");
                                    Console.WriteLine("  s`sMN: sMm`                                                       `+NMMMm+`     `+shhhoss:        ");
                                    Console.WriteLine("  . dMs  -MN`                                                       sMMMm+.           ``            ");
                                    Console.WriteLine("   /MN`  `NM-                                                       dMNdmmho-                       ");
                                    Console.WriteLine("   mM+    hMo                                                       -hNmo:+hmh.                     ");
                                    Console.WriteLine("  oMd     .Nd                                                        `:yNd-.ms                      ");
                                    Console.WriteLine("`oNN/.`    hNyo:`                                                      `/Nh`.  ``   .-.             ");
                                    Console.WriteLine(" .-yydmhsooydMMNmmmmhssso+++:-                                         `+hdhsyhmNdhsdNNmh:    .::-` ");
                                    Console.WriteLine("     `:ydNMMMMMMMMMMdo----:::-                                           ``./oyddmNMMMMMMNy/. `omNd`");
                                    Console.WriteLine("         `...../ooo+:`                                                           ``.+hMMMMMNd   `:+.");
                                    Console.WriteLine("                                                                                   /yss+//.         ");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("Dia 3, Trem do Meio-dia, 11:56");
                                    Console.WriteLine("[Ladrão] Essa vista é muito boa. Ei, você aí! Acho que eu te conheço!");
                                    Console.WriteLine("[Ladrão] Essa cara pálida, esses ossos aparecendo...");
                                    Console.WriteLine("[Ladrão] Você é o... Clint Eastwood? Cara, eu adoro os seus filmes.");
                                    Console.WriteLine("[Esqueleto] ...");
                                    Console.WriteLine("        `.hs+                                                                            shd..       ");
                                    Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                    Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                    Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                    Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                    Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                    Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                    Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                    Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                    Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                    Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                    Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                    Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                    Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                    Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                    Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                    Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("Dia 3, Trem do Meio dia, 11:57");
                                    Console.WriteLine("[Esqueleto] Idiota, eu sou o Esqueleto, o maior bandido do Oeste!");
                                    Console.WriteLine("[Esqueleto] E você tem que me matar agora porque eu estou carregando o diamante de Silverneck!");
                                    Console.WriteLine("[Ladrão] Não tô afim agora. Tô curtindo a viagem.");
                                    Console.WriteLine("        `.hs+                                                                            shd..       ");
                                    Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                    Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                    Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                    Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                    Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                    Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                    Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                    Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                    Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                    Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                    Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                    Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                    Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                    Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                    Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                    Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("Dia 3, Trem do Meio dia, 11:58");
                                    Console.WriteLine("[Esqueleto] Não? Eu tenho uma caverna escondida nos subterrâneos dos fortes apaches com milhares de itens valiosos e você não quer me matar?");
                                    Console.WriteLine("[Esqueleto] Aqui, fica com essa dentadura de ouro e essa caveirinha esculpida em prata. Agora, deixa eu voltar pra minha caverna.");
                                    Console.WriteLine("[Ladrão] Espera, eu tive uma ideia!");
                                    Console.WriteLine("        `.hs+                                                                            shd..       ");
                                    Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                    Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                    Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                    Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                    Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                    Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                    Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                    Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                    Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                    Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                    Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                    Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                    Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                    Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                    Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                    Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                    Console.ReadKey();
                                    Console.Clear();
                                    Console.WriteLine("Dia 3, Trem do Meio dia, 11:59");
                                    Console.WriteLine("[Ladrão] Por que a gente não faz um duelo nesse trem, valendo esse diamante gigante que você tá segurando aí?");
                                    Console.WriteLine("[Esqueleto] ... Tá bom, vamos lá.");
                                    Console.WriteLine("        `.hs+                                                                            shd..       ");
                                    Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                    Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                    Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                    Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                    Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                    Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                    Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                    Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                    Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                    Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                    Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                    Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                    Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                    Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                    Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                    Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                    Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                    Console.ReadKey();
                                    Console.Clear();
                                    tempus = 0;
                                    tempus10 = 0;
                                    do
                                    {
                                        Console.WriteLine("Dia 3, Trem do Meio-dia, 12:{1}{0}", tempus10, tempus);
                                        Console.WriteLine("É meio dia.");
                                        Console.WriteLine("        `.hs+                                                                            shd..       ");
                                        Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                        Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                        Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                        Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                        Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                        Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                        Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                        Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                        Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                        Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                        Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                        Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                        Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                        Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                        Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                        Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                        Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                        Console.WriteLine("Ladrão, faça a sua decisão: (1)Atirar  (2)Recarregar  (3)Esquivar");
                                        escolha = int.Parse(Console.ReadLine());
                                        Console.Clear();



                                        if (escolha == 1)
                                        {
                                            Console.WriteLine("Ladrão sacou o seu revólver...");
                                            if (bala < 1)
                                            {
                                                Console.WriteLine("Mas estava sem balas!");
                                                escolha = 4;
                                            }
                                            else
                                            {
                                                Console.WriteLine("E apertou o gatilho!");
                                                bala--;
                                            }
                                        }
                                        else if (escolha == 2)
                                        {
                                            Console.WriteLine("Ladrão decidiu colocar uma bala em seu revólver...");
                                            bala++;
                                        }
                                        else if (escolha == 3)
                                        {
                                            Console.WriteLine("Ladrão decidiu se esquivar para escapar do tiro...");
                                        }

                                        Random rand = new Random();
                                        escolha2 = rand.Next(1, 3);
                                        if (primeiroturno == 0)
                                        {
                                            Console.WriteLine("Esqueleto decidiu colocar uma bala em seu revólver...");
                                            bala2++;
                                            primeiroturno = 1;
                                            escolha2 = 2;
                                        }
                                        else
                                        {
                                            if (escolha2 == 1)
                                            {
                                                Console.WriteLine("Esqueleto sacou o seu revólver...");
                                                if (bala2 < 1)
                                                {
                                                    Console.WriteLine("Mas estava sem balas!");
                                                    escolha2 = 4;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("E apertou o gatilho!");
                                                    bala2--;
                                                }
                                            }
                                            else if (escolha2 == 2)
                                            {
                                                Console.WriteLine("Esqueleto decidiu colocar uma bala em seu revólver...");
                                                bala2++;
                                            }
                                            else if (escolha2 == 3)
                                            {
                                                Console.WriteLine("Esqueleto decidiu se esquivar para escapar do tiro...");
                                            }

                                        }

                                        if (escolha == 1 && escolha2 == 1)
                                        {
                                            Console.WriteLine("       ..dhs                                                                            shd..       ");
                                            Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                            Console.WriteLine("     -osNMMd/..```    ```                                                  ```    ```../dMMNso-     ");
                                            Console.WriteLine("    .mMMMMMNddmmdhyyhyms/-:-                                            -:-/smyhyyhdmmddNMMMMMm.    ");
                                            Console.WriteLine("    hNNMMMMo   ````..::                                                      ::..````   oMMMMNNh    ");
                                            Console.WriteLine("   :NsdMMMM/                                                                            /MMMMdsN:   ");
                                            Console.WriteLine("   hm`dMMMMs                                                                            sMMMMd`mh   ");
                                            Console.WriteLine("  :No-NMMMMh                                                                            hMMMMN-oN:  ");
                                            Console.WriteLine("  /N/NMMmMMm-                                                                          -mMMmMMN/N/ ");
                                            Console.WriteLine("  syyMMd.NMM:                                                                          :MMN.dMMyys  ");
                                            Console.WriteLine("  s`sMN: sMm`                                                                          `mMs :NMs`s  ");
                                            Console.WriteLine("  . dMs  -MN`                                                                          `NM-  sMd .  ");
                                            Console.WriteLine("   /MN`  `NM-                                                                          -MN`  `NM/  ");
                                            Console.WriteLine("   mM+    hMo                                                                          oMh    +Mm  ");
                                            Console.WriteLine("  oMd     .Nd                                                                          dN.     dMo  ");
                                            Console.WriteLine("`oNN/.`    hNyo:`                                                                  `:oyNh    `./NNo`");
                                            Console.WriteLine(" .-yydmhsooydMMNmmmmhssso+++:-                                        -:+++ossshmmmmNMMdyooshmdyy-. ");
                                            Console.WriteLine("     `:ydNMMMMMMMMMMdo----:::-                                        -:::----odMMMMMMMMMMNdy:`     ");
                                            Console.WriteLine("         `...../ooo+:`                                                        `:+ooo/.....`         ");
                                            Console.WriteLine("Os dois caubóis atiram ao mesmo tempo! Cada bala ricocheteia a outra, que explodem no ar!");

                                        }
                                        if (escolha == 1 && escolha2 == 2 || escolha == 1 && escolha2 == 4)
                                        {

                                            morte = 1;
                                            a = 1;

                                            Console.WriteLine("        ..dhs                                                                                        ");
                                            Console.WriteLine("       `dMMm-`                                                                                      ");
                                            Console.WriteLine("     -osNMMd/..```    ```                                                                           ");
                                            Console.WriteLine("    .mMMMMMNddmmdhyyhyms/-:-                                          `                 .           ");
                                            Console.WriteLine("   hNNMMMMo   ````..::                                              +h/       .-.     -h-          ");
                                            Console.WriteLine("   :NsdMMMM/                                                         `dd-    ` dMN-    ymh`         ");
                                            Console.WriteLine("   hm`dMMMMs                                                          `ydyyhhhyNMm-   `:``          ");
                                            Console.WriteLine("  :No-NMMMMh                                                            .:yMMMMMMNh.                ");
                                            Console.WriteLine("  /N/NMMmMMm-                                                          .+mMMMMMNdmMy`               ");
                                            Console.WriteLine("  syyMMd.NMM:                                                         :mMMMMms:-`.hMy:--.+:-        ");
                                            Console.WriteLine("  s`sMN: sMm`                                                       `+NMMMm+`     `+shhhoss:        ");
                                            Console.WriteLine("  . dMs  -MN`                                                       sMMMm+.           ``            ");
                                            Console.WriteLine("   /MN`  `NM-                                                       dMNdmmho-                       ");
                                            Console.WriteLine("   mM+    hMo                                                       -hNmo:+hmh.                     ");
                                            Console.WriteLine("  oMd     .Nd                                                        `:yNd-.ms                      ");
                                            Console.WriteLine("`oNN/.`    hNyo:`                                                      `/Nh`.  ``   .-.             ");
                                            Console.WriteLine(" .-yydmhsooydMMNmmmmhssso+++:-                                         `+hdhsyhmNdhsdNNmh:    .::-` ");
                                            Console.WriteLine("     `:ydNMMMMMMMMMMdo----:::-                                           ``./oyddmNMMMMMMNy/. `omNd`");
                                            Console.WriteLine("         `...../ooo+:`                                                           ``.+hMMMMMNd   `:+.");
                                            Console.WriteLine("                                                                                   /yss+//.         ");


                                            Console.WriteLine("O Ladrão atira mais rápido, acertando em cheio o Esqueleto");

                                        }
                                        if (escolha == 1 && escolha2 == 3)
                                        {

                                            Console.WriteLine("        `.hs+                                                                            shd..       ");
                                            Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                            Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                            Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                            Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                            Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                            Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                            Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                            Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                            Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                            Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                            Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                            Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                            Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                            Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                            Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                            Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                            Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                            Console.WriteLine("O Ladrão efetua o disparo, mas o Esqueleto rapidamente se esquiva!");
                                        }
                                        if (escolha == 2 && escolha2 == 2)
                                        {
                                            Console.WriteLine("        `.hs+                                                                            shd..       ");
                                            Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                            Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                            Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                            Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                            Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                            Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                            Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                            Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                            Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                            Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                            Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                            Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                            Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                            Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                            Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                            Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                            Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                            Console.WriteLine("Os dois caubóis decidem recarregar ao mesmo tempo!");
                                        }


                                        if (escolha == 2 && escolha2 == 1 || escolha == 4 && escolha2 == 1)
                                        {
                                            Console.WriteLine("                                                                                         shd..");
                                            Console.WriteLine("                                                                                      `-mMMd` ");
                                            Console.WriteLine("                                                                           ```    ```../dMMNso- ");
                                            Console.WriteLine("           .                 `                                          -:-/smyhyyhdmmddNMMMMMm. ");
                                            Console.WriteLine("          -h-     .-.       /h+                                              ::..````   oMMMMNNh   ");
                                            Console.WriteLine("         `hmy    -NMd `    -dd`                                                         /MMMMdsN:   ");
                                            Console.WriteLine("          ``:`   -mMNyhhhyydy`                                                          sMMMMd`mh   ");
                                            Console.WriteLine("                .hNMMMMMMy:.                                                            hMMMMN-oN:  ");
                                            Console.WriteLine("               `yMmdNMMMMMm+.                                                          -mMMmMMN/N/  ");
                                            Console.WriteLine("        -:+.--:yMh.`-:smMMMMm:                                                         :MMN.dMMyys  ");
                                            Console.WriteLine("        :ssohhhs+`     `+mMMMN+`                                                       `mMs :NMs`s  ");
                                            Console.WriteLine("            ``           .+mMMMs                                                       `NM-  sMd .  ");
                                            Console.WriteLine("                       -ohmmdNMd                                                       -MN`  `NM/   ");
                                            Console.WriteLine("                     .hmh+:omNh-                                                       oMh    +Mm   ");
                                            Console.WriteLine("                      sm.-dNy:`                                                        dN.     dMo  ");
                                            Console.WriteLine("             .-.   ``  .`hN/`                                                      `:oyNh    `./NNo`");
                                            Console.WriteLine(" `-::.    :hmNNdshdNmhyshdh+`                                         -:+++ossshmmmmNMMdyooshmdyy-. ");
                                            Console.WriteLine("`dNmo` ./yNMMMMMMNmddyo/.``                                           -:::----odMMMMMMMMMMNdy:`     ");
                                            Console.WriteLine(".+:`   dNMMMMMh+.``                                                           `:+ooo/.....`         ");
                                            Console.WriteLine("         .//+ssy/                                                                                   ");
                                            morte = 1;
                                            a = 2;

                                            Console.WriteLine("O Esqueleto atira mais rápido, acertando em cheio o Ladrão!");
                                        }
                                        if (escolha == 3 && escolha2 == 1)
                                        {
                                            Console.WriteLine("        `.hs+                                                                            shd..       ");
                                            Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                            Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                            Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                            Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                            Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                            Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                            Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                            Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                            Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                            Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                            Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                            Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                            Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                            Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                            Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                            Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                            Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                            Console.WriteLine("O Esqueleto efetua o disparo, mas o Ladrão rapidamente se esquiva!");

                                        }

                                        if (escolha == 3 && escolha2 == 3)
                                        {
                                            Console.WriteLine("        `.hs+                                                                            shd..       ");
                                            Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                            Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                            Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                            Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                            Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                            Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                            Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                            Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                            Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                            Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                            Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                            Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                            Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                            Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                            Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                            Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                            Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                            Console.WriteLine("Os dois caubóis escolhem se esquivar e ninguém atira!");
                                        }

                                        if (escolha == 3 && escolha2 == 2 || escolha == 2 && escolha2 == 3 || escolha == 4 && escolha2 == 4 || escolha == 3 && escolha2 == 4 || escolha == 4 && escolha2 == 3 || escolha == 2 && escolha2 == 4 || escolha == 4 && escolha2 == 2)
                                        {
                                            Console.WriteLine("        `.hs+                                                                            shd..       ");
                                            Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                            Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                            Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                            Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                            Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                            Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                            Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                            Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                            Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                            Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                            Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                            Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                            Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                            Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                            Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                            Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                            Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                            Console.WriteLine("Ninguém decide atacar neste turno!");
                                        }

                                        Console.ReadKey();
                                        Console.Clear();
                                        tempus++;
                                        if (tempus >= 10)
                                        {
                                            tempus = 0;
                                            tempus10++;
                                        }
                                        if (tempus10 == 6)
                                        {
                                            a = 3;
                                            morte = 1;
                                        }
                                    }
                                    while (morte != 1);
                                    if (a == 1)
                                    {
                                        Console.WriteLine("Dia 3, Trem do Meio-dia, 12:01");
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.Clear();
                                        Console.WriteLine("              MM                                              MM,");
                                        Console.WriteLine("            O8M~                                               M M");
                                        Console.WriteLine("          7N :M,                                               MN  M=");
                                        Console.WriteLine("        ?M   M M                                               MM    8N ");
                                        Console.WriteLine("      =M    M.  M:                                            MIMMMD   :M");
                                        Console.WriteLine("    :M      M     M+                                        .M  ,+  :MMM? M.");
                                        Console.WriteLine("   M.      M        M=                                     MI    M      +MMMM");
                                        Console.WriteLine(" M,       .7           MM,                             OMZ       M           M");
                                        Console.WriteLine("M         M              :MM$MMMM$=,         ,=$MMMM.            7.           M");
                                        Console.WriteLine("+        M             MM+  M                    MM MM            M           O");
                                        Console.WriteLine("        M          MM        8                  M      $M         M.           M");
                                        Console.WriteLine("       +O        MM           M                M?        M~       ~O           I");
                                        Console.WriteLine("M      M      :MM              M              MM          $M       M          M ");
                                        Console.WriteLine("  M  M ~MN                       M          M.                 MM   M      M   ");
                                        Console.WriteLine("   MNMMM                          M        MM                   $M  M     M    ");
                                        Console.WriteLine("    M=                            I+      MM                      MMM=  M      ");
                                        Console.WriteLine("       MI$M=                        M    M.                     :MMN~          ");
                                        Console.WriteLine("         M?  MM?                     M  M7                  ~MM  :M            ");
                                        Console.WriteLine("           M    OMM+                 D~~M                7MM    M~             ");
                                        Console.WriteLine("             M      :MMMM~            MM           ~MMMM      ,M               ");
                                        Console.WriteLine("               M      M:   ~$MMMMMMMMMMMMMMMMMMI.    =8      M                 ");
                                        Console.WriteLine("                .M     ZM             M,            $7     .=             ");
                                        Console.WriteLine("                    M$    M=           M          M,    D+       ");
                                        Console.WriteLine("                        M    M         M        M=   D?          ");
                                        Console.WriteLine("                          M   M        M       M,  .M          ");
                                        Console.WriteLine("                            M  :M      M      M.  M        ");
                                        Console.WriteLine("                             .M  M     Z     M  O7      ");
                                        Console.WriteLine("                               M7 M    =:   M, M      ");
                                        Console.WriteLine("                                 MIOO   D  M.Z7 ");
                                        Console.WriteLine("                                   M=M  M M M   ");
                                        Console.WriteLine("                                     MM:MMM       ");
                                        Console.WriteLine("                                        :      ");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("O maquinista avisa aos passageiros que o trem chegou à cidade de Silverneck");
                                        //imagem de trem aqui
                                        Console.WriteLine("O Ladrão volta para a cidade com o diamante de Silverneck.");
                                        //imagem de um diamante ou da delegacia talvez
                                        Console.WriteLine("Clint Eastwood, o Estranho sem Nome, passa cavalgando do lado do ladrão, roubando o Diamante de Silverneck, deixando o Ladrão de mãos vazias novamente.");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                }
                            }
                            Console.WriteLine(" _______  ___   __   __    ______   _______        ___  _______  _______  _______");
                            Console.WriteLine("|       ||   | |  |_|  |  |      | |       |      |   ||       ||       ||       |");
                            Console.WriteLine("|    ___||   | |       |  |  _    ||    ___|      |   ||   _   ||    ___||   _   |");
                            Console.WriteLine("|   |___ |   | |       |  | | |   ||   |___       |   ||  | |  ||   | __ |  | |  |");
                            Console.WriteLine("|    ___||   | |       |  | |_|   ||    ___|   ___|   ||  |_|  ||   ||  ||  |_|  |");
                            Console.WriteLine("|   |    |   | | ||_|| |  |       ||   |___   |       ||       ||   |_| ||       |");
                            Console.WriteLine("|___|    |___| |_|   |_|  |______| |_______|  |_______||_______||_______||_______|");
                            Console.WriteLine("           _______  _______  _     _  _______  _______  __   __                  ");
                            Console.WriteLine("          |     __||       || | _ | ||  _    ||       ||  | |  |                 ");
                            Console.WriteLine("          |    |   |   _   || || || || |_|   ||   _   ||  |_|  |                  ");
                            Console.WriteLine("          |    |   |  | |  ||       ||       ||  | |  ||       |                  ");
                            Console.WriteLine("          |    |   |  |_|  ||       ||  _   | |  |_|  ||_     _|                  ");
                            Console.WriteLine("          |    |__ |       ||   _   || |_|   ||       |  |   |                    ");
                            Console.WriteLine("          |_______||_______||__| |__||_______||_______|  |___|                    ");
                            if (a == 3)
                                Console.WriteLine("Tempo esgotado! Você perdeu!");
                            Console.ReadKey();
                        }
                        

                        break;
                    case 2:
                        int p1 = -1;
                        int p2 = -1;
                        int cen = -1;
                        string[] jog = {"Xerife", "Caçador de Recompensas", "Ladrão" };
                        string[] cena = { "", "Delegacia", "Saloon", "Banco de Silverneck", "Trem do Meio-dia" };
                        for (int i = 1; i < 3; i++)
                        {
                            Console.Clear();
                            Console.WriteLine("Jogador {0}, Escolha seu Personagem:", i);
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("(1) Xerife");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("(2) Caçador de Recompensas");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("(3) Ladrão");
                            int jogaux = int.Parse(Console.ReadLine());
                            if (jogaux != p1 + 1)
                            {
                                if (jogaux == 1 || jogaux == 2 || jogaux == 3)
                                {

                                    {
                                        if (i == 1)
                                            p1 = jogaux - 1;
                                        else
                                            p2 = jogaux - 1;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Escolha um personagem válido!");
                                    Console.ReadKey();
                                    i--;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Esse personagem já foi escolhido!");
                                Console.ReadKey();
                                i--;
                            }
                        }
                        bool lib = false;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        do
                        {
                            Console.WriteLine("Selecione o cenário: ");
                            Console.WriteLine("(1) Delegacia\n(2) Saloon\n(3) Banco de Silverneck\n(4) Trem do Meio-dia");
                            cen = int.Parse(Console.ReadLine());
                            if (cen == 1 || cen == 2 || cen == 3 || cen == 4)
                            {
                                lib = true;
                            }
                            else { 

                            Console.Clear();
                            Console.WriteLine("Opção inválida!");
                        }
                        }
                        while (lib == false);

                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Dia 1, {0}, 12:{1}{2}",cena[cen],tempus10, tempus);
                            Console.WriteLine("É meio dia.");
                            Console.WriteLine("        `.hs+                                                                            shd..       ");
                            Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                            Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                            Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                            Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                            Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                            Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                            Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                            Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                            Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                            Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                            Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                            Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                            Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                            Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                            Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                            Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                            Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");

                            Console.WriteLine("{0}, faça a sua decisão: (1)Atirar  (2)Recarregar  (3)Esquivar",jog[p1]);
                            escolha = int.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("Dia 1, {0}, 12:{1}{2}", cena[cen],tempus10, tempus);
                            Console.WriteLine("É meio dia.");
                            Console.WriteLine("        `.hs+                                                                            shd..       ");
                            Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                            Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                            Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                            Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                            Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                            Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                            Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                            Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                            Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                            Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                            Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                            Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                            Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                            Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                            Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                            Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                            Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                            Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                            Console.WriteLine("{0}, faça a sua decisão: (1)Atirar  (2)Recarregar  (3)Esquivar",jog[p2]);
                            escolha2 = int.Parse(Console.ReadLine());
                            Console.Clear();

                            if (escolha == 1)
                            {
                                Console.WriteLine("{0} sacou o seu revólver...",jog[p1]);
                                if (bala < 1)
                                {
                                    Console.WriteLine("Mas estava sem balas!");
                                    escolha = 4;
                                }
                                else
                                    Console.WriteLine("E apertou o gatilho!");
                            }
                            else if (escolha == 2)
                            {
                                Console.WriteLine("{0} decidiu colocar uma bala em seu revólver...",jog[p1]);
                                bala++;
                            }
                            else if (escolha == 3)
                            {
                                Console.WriteLine("{0} decidiu se esquivar para escapar do tiro...",jog[p1]);
                            }

                            if (escolha2 == 1)
                            {
                                Console.WriteLine("{0} sacou o seu revólver...",jog[p2]);
                                if (bala2 < 1)
                                {
                                    Console.WriteLine("Mas estava sem balas!");
                                    escolha2 = 4;
                                }
                                else
                                    Console.WriteLine("E apertou o gatilho!");
                            }
                            else if (escolha2 == 2)
                            {
                                Console.WriteLine("{0} decidiu colocar uma bala em seu revólver...",jog[p2]);
                                bala2++;
                            }
                            else if (escolha2 == 3)
                            {
                                Console.WriteLine("{0} decidiu se esquivar para escapar do tiro...",jog[p2]);
                            }


                            if (escolha == 1 && escolha2 == 1)
                            {
                                Console.WriteLine("       ..dhs                                                                            shd..       ");
                                Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                Console.WriteLine("     -osNMMd/..```    ```                                                  ```    ```../dMMNso-     ");
                                Console.WriteLine("    .mMMMMMNddmmdhyyhyms/-:-                                            -:-/smyhyyhdmmddNMMMMMm.    ");
                                Console.WriteLine("    hNNMMMMo   ````..::                                                      ::..````   oMMMMNNh    ");
                                Console.WriteLine("   :NsdMMMM/                                                                            /MMMMdsN:   ");
                                Console.WriteLine("   hm`dMMMMs                                                                            sMMMMd`mh   ");
                                Console.WriteLine("  :No-NMMMMh                                                                            hMMMMN-oN:  ");
                                Console.WriteLine("  /N/NMMmMMm-                                                                          -mMMmMMN/N/ ");
                                Console.WriteLine("  syyMMd.NMM:                                                                          :MMN.dMMyys  ");
                                Console.WriteLine("  s`sMN: sMm`                                                                          `mMs :NMs`s  ");
                                Console.WriteLine("  . dMs  -MN`                                                                          `NM-  sMd .  ");
                                Console.WriteLine("   /MN`  `NM-                                                                          -MN`  `NM/  ");
                                Console.WriteLine("   mM+    hMo                                                                          oMh    +Mm  ");
                                Console.WriteLine("  oMd     .Nd                                                                          dN.     dMo  ");
                                Console.WriteLine("`oNN/.`    hNyo:`                                                                  `:oyNh    `./NNo`");
                                Console.WriteLine(" .-yydmhsooydMMNmmmmhssso+++:-                                        -:+++ossshmmmmNMMdyooshmdyy-. ");
                                Console.WriteLine("     `:ydNMMMMMMMMMMdo----:::-                                        -:::----odMMMMMMMMMMNdy:`     ");
                                Console.WriteLine("         `...../ooo+:`                                                        `:+ooo/.....`         ");
                                Console.WriteLine("Os dois caubóis atiram ao mesmo tempo! Cada bala ricocheteia a outra, que explodem no ar!");

                            }
                            if (escolha == 1 && escolha2 == 2 || escolha == 1 && escolha2 == 4)
                            {

                                morte = 1;
                                a = 1;

                                Console.WriteLine("        ..dhs                                                                                        ");
                                Console.WriteLine("       `dMMm-`                                                                                      ");
                                Console.WriteLine("     -osNMMd/..```    ```                                                                           ");
                                Console.WriteLine("    .mMMMMMNddmmdhyyhyms/-:-                                          `                 .           ");
                                Console.WriteLine("   hNNMMMMo   ````..::                                              +h/       .-.     -h-          ");
                                Console.WriteLine("   :NsdMMMM/                                                         `dd-    ` dMN-    ymh`         ");
                                Console.WriteLine("   hm`dMMMMs                                                          `ydyyhhhyNMm-   `:``          ");
                                Console.WriteLine("  :No-NMMMMh                                                            .:yMMMMMMNh.                ");
                                Console.WriteLine("  /N/NMMmMMm-                                                          .+mMMMMMNdmMy`               ");
                                Console.WriteLine("  syyMMd.NMM:                                                         :mMMMMms:-`.hMy:--.+:-        ");
                                Console.WriteLine("  s`sMN: sMm`                                                       `+NMMMm+`     `+shhhoss:        ");
                                Console.WriteLine("  . dMs  -MN`                                                       sMMMm+.           ``            ");
                                Console.WriteLine("   /MN`  `NM-                                                       dMNdmmho-                       ");
                                Console.WriteLine("   mM+    hMo                                                       -hNmo:+hmh.                     ");
                                Console.WriteLine("  oMd     .Nd                                                        `:yNd-.ms                      ");
                                Console.WriteLine("`oNN/.`    hNyo:`                                                      `/Nh`.  ``   .-.             ");
                                Console.WriteLine(" .-yydmhsooydMMNmmmmhssso+++:-                                         `+hdhsyhmNdhsdNNmh:    .::-` ");
                                Console.WriteLine("     `:ydNMMMMMMMMMMdo----:::-                                           ``./oyddmNMMMMMMNy/. `omNd`");
                                Console.WriteLine("         `...../ooo+:`                                                           ``.+hMMMMMNd   `:+.");
                                Console.WriteLine("                                                                                   /yss+//.         ");


                                Console.WriteLine("O {0} atira mais rápido, acertando em cheio o {1}",jog[p1],jog[p2]);

                            }
                            if (escolha == 1 && escolha2 == 3)
                            {

                                Console.WriteLine("        `.hs+                                                                            shd..       ");
                                Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                Console.WriteLine("O {0} efetua o disparo, mas o {1} rapidamente se esquiva!",jog[p1],jog[p2]);
                            }
                            if (escolha == 2 && escolha2 == 2)
                            {
                                Console.WriteLine("        `.hs+                                                                            shd..       ");
                                Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                Console.WriteLine("Os dois caubóis decidem recarregar ao mesmo tempo!");
                            }


                            if (escolha == 2 && escolha2 == 1 || escolha == 4 && escolha2 == 1)
                            {
                                Console.WriteLine("                                                                                         shd..");
                                Console.WriteLine("                                                                                      `-mMMd` ");
                                Console.WriteLine("                                                                           ```    ```../dMMNso- ");
                                Console.WriteLine("           .                 `                                          -:-/smyhyyhdmmddNMMMMMm. ");
                                Console.WriteLine("          -h-     .-.       /h+                                              ::..````   oMMMMNNh   ");
                                Console.WriteLine("         `hmy    -NMd `    -dd`                                                         /MMMMdsN:   ");
                                Console.WriteLine("          ``:`   -mMNyhhhyydy`                                                          sMMMMd`mh   ");
                                Console.WriteLine("                .hNMMMMMMy:.                                                            hMMMMN-oN:  ");
                                Console.WriteLine("               `yMmdNMMMMMm+.                                                          -mMMmMMN/N/  ");
                                Console.WriteLine("        -:+.--:yMh.`-:smMMMMm:                                                         :MMN.dMMyys  ");
                                Console.WriteLine("        :ssohhhs+`     `+mMMMN+`                                                       `mMs :NMs`s  ");
                                Console.WriteLine("            ``           .+mMMMs                                                       `NM-  sMd .  ");
                                Console.WriteLine("                       -ohmmdNMd                                                       -MN`  `NM/   ");
                                Console.WriteLine("                     .hmh+:omNh-                                                       oMh    +Mm   ");
                                Console.WriteLine("                      sm.-dNy:`                                                        dN.     dMo  ");
                                Console.WriteLine("             .-.   ``  .`hN/`                                                      `:oyNh    `./NNo`");
                                Console.WriteLine(" `-::.    :hmNNdshdNmhyshdh+`                                         -:+++ossshmmmmNMMdyooshmdyy-. ");
                                Console.WriteLine("`dNmo` ./yNMMMMMMNmddyo/.``                                           -:::----odMMMMMMMMMMNdy:`     ");
                                Console.WriteLine(".+:`   dNMMMMMh+.``                                                           `:+ooo/.....`         ");
                                Console.WriteLine("         .//+ssy/                                                                                   ");

                                morte = 1;
                                a = 2;

                                Console.WriteLine("O {0} atira mais rápido, acertando em cheio o {1}",jog[p1],jog[p2]);
                            }
                            if (escolha == 3 && escolha2 == 1)
                            {
                                Console.WriteLine("        `.hs+                                                                            shd..       ");
                                Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                Console.WriteLine("O {0} efetua o disparo, mas o {1} rapidamente se esquiva!",jog[p2],jog[p1]);

                            }

                            if (escolha == 3 && escolha2 == 3)
                            {
                                Console.WriteLine("        `.hs+                                                                            shd..       ");
                                Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                Console.WriteLine("Os dois caubóis escolhem se esquivar e ninguém atira!");
                            }

                            if (escolha == 3 && escolha2 == 2 || escolha == 2 && escolha2 == 3 || escolha == 4 && escolha2 == 4 || escolha == 3 && escolha2 == 4 || escolha == 4 && escolha2 == 3 || escolha == 2 && escolha2 == 4 || escolha == 4 && escolha2 == 2)
                            {
                                Console.WriteLine("        `.hs+                                                                            shd..       ");
                                Console.WriteLine("       `dMMm-`                                                                        `-mMMd`       ");
                                Console.WriteLine("     ./oNMMh:                                                                          +dMMNso-     ");
                                Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                Console.WriteLine("    `mMMMMMMN-                                                                        -NNMMMMMm.    ");
                                Console.WriteLine("    yNNMMMMsNy                                                                        yNsMMMMNNh    ");
                                Console.WriteLine("   -NydMMMM+hm`                                                                      `Nh/MMMMdsN:   ");
                                Console.WriteLine("   ym.dMMMMs+M.                                                                      -M/sMMMMd`mh   ");
                                Console.WriteLine("  -No.NMMMMy-M/                                                                      +M-hMMMMN-oN:  ");
                                Console.WriteLine("  /N:mMMmMMm:N/                                                                      /N:mMMmMMN/N/  ");
                                Console.WriteLine("  shyMMm-NMM/m:                                                                      :m/MMN.dMMyys  ");
                                Console.WriteLine("  y`sMM/ yMm.+-                                                                      -+`mMs :NMs`s  ");
                                Console.WriteLine("  . dMy  -MN ``                                                                      ```NM-  sMd .  ");
                                Console.WriteLine("   :MN`  `NM-                                                                          -MN`  `NM/   ");
                                Console.WriteLine("   dMo    dMo                                                                          oMh    +Mm   ");
                                Console.WriteLine("  +Mm`    -Nd                                                                          dN.     dMo  ");
                                Console.WriteLine("`/mM/`     dNs/.                                                                   `:oyNh    `./NNo`");
                                Console.WriteLine(" -:hhmdso//sdMMNdddhs+-                                                      :ohmmmmNMMdyooshmdyy-. ");
                                Console.WriteLine("    ``+hmNMMMMMMMMMMds:                                                      -odMMMMMMMMMMNdy:`     ");
                                Console.WriteLine("        ``-----oyyso/.                                                        `:+ooo/.....`         ");
                                Console.WriteLine("Ninguém decide atacar neste turno!");
                            }

                            Console.ReadKey();
                            Console.Clear();
                            tempus++;
                            if (tempus >= 10)
                            {
                                tempus = 0;
                                tempus10++;
                            }
                            if (tempus10 == 6)
                            {
                                a = 3;
                                morte = 1;
                            }
                        }
                        while (morte != 1);

                        Console.WriteLine(" _______  ___   __   __    ______   _______        ___  _______  _______  _______");
                        Console.WriteLine("|       ||   | |  |_|  |  |      | |       |      |   ||       ||       ||       |");
                        Console.WriteLine("|    ___||   | |       |  |  _    ||    ___|      |   ||   _   ||    ___||   _   |");
                        Console.WriteLine("|   |___ |   | |       |  | | |   ||   |___       |   ||  | |  ||   | __ |  | |  |");
                        Console.WriteLine("|    ___||   | |       |  | |_|   ||    ___|   ___|   ||  |_|  ||   ||  ||  |_|  |");
                        Console.WriteLine("|   |    |   | | ||_|| |  |       ||   |___   |       ||       ||   |_| ||       |");
                        Console.WriteLine("|___|    |___| |_|   |_|  |______| |_______|  |_______||_______||_______||_______|");
                        Console.WriteLine("           _______  _______  _     _  _______  _______  __   __                  ");
                        Console.WriteLine("          |     __||       || | _ | ||  _    ||       ||  | |  |                 ");
                        Console.WriteLine("          |    |   |   _   || || || || |_|   ||   _   ||  |_|  |                  ");
                        Console.WriteLine("          |    |   |  | |  ||       ||       ||  | |  ||       |                  ");
                        Console.WriteLine("          |    |   |  |_|  ||       ||  _   | |  |_|  ||_     _|                  ");
                        Console.WriteLine("          |    |__ |       ||   _   || |_|   ||       |  |   |                    ");
                        Console.WriteLine("          |_______||_______||__| |__||_______||_______|  |___|                    ");
                        if (a == 1)
                            Console.WriteLine("Vencedor: {0}", jog[p1]);
                        else if (a == 2)
                            Console.WriteLine("Vencedor: {0}", jog[p2]);
                        else
                            Console.WriteLine("Tempo Esgotado! Os dois perdem!");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Instruções:");
                        Console.WriteLine("Olá, caubói. Seja bem-vindo à Silverneck. Uma cidade cobiçada por todos os ladrões do Oeste.\n");
                        Console.WriteLine("Em High Noon Duel, você entrará na pele de três personagens clássicos de faroeste: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Xerife\nAlinhamento: Lawful");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Caçador de Recompensas\nAlinhamento: Neutral");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Ladrão\nAlinhamento: Chaotic");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("No estilo de jogos de luta clássicos, você deverá resolver todos os desafios de cada jornada.");
                        Console.WriteLine("Todos os combates são decididos ao Meio-dia! Você perderá se a luta passar de 12:59!");
                        Console.WriteLine("\nComo jogar:\nA você, são dadas três opções: (1)Atirar (2)Recarregar (3)Esquivar");
                        Console.WriteLine("Todo o começo de duelo, ninguém possui balas no revólver! Considere recarregar em todos os primeiros turnos.");
                        Console.WriteLine("O jogo não avisa se você ainda possui balas! Fique atento a isso.\n");
                        Console.WriteLine("Criado por Checkpoint East - Thiago Yasue, Roger Norio");
                        Console.ReadKey();
                        break;
                    default:
                        menu = 4;
                    break;
                }
            }
            while (menu != 4);
            Console.SetCursorPosition(80, 60);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("See You Western Cowboy...");
            Console.ReadKey();
        }
    }
}
