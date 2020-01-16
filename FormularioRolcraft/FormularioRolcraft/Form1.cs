using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioRolcraft {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        int combatTotal = 0;
        int phisicalTotal = 0;
        int knowledgesTotal = 0;
        int mentalTotal = 0;
        int specialTotal = 0;
        int arcaneTotal = 0;
        int arcaneCommonTotal = 0;
        int arcanePureTotal = 0;
        int arcaneForbiddenTotal = 0;
        int elementalTotal = 0;
        int elementalDruidTotal = 0;
        int elementalShamanTotal = 0;
        int divineTotal = 0;
        int divineLightTotal = 0;
        int divineShadowTotal = 0;
        int divineOldGodTotal = 0;
        int runicTotal = 0;
        int scienceTotal = 0;
        int etiqueteTotal = 0;
        int natureTotal = 0;
        int historyTotal = 0;
        int humanTotal = 0;
        int medicineTotal = 0;
        int artOfWarTotal = 0;
        int survivalTotal = 0;
        int navigationTotal = 0;
        int advantagesTotal = 0;
        int minPH = 60;
        int minPC = 41;
        int maxPC = 42;
        bool tabsAdded = false;
        Races raceSelected = new Races();
        RacialsMaxMin maxmins = new RacialsMaxMin();

        int cost(int value) {
            switch (value) {
                case 1:
                    return 1;
                case 2:
                    return 1;
                case 3:
                    return 1;
                case 4:
                    return 1;
                case 5:
                    return 1;
                case 6:
                    return 2;
                case 7:
                    return 2;
                case 8:
                    return 3;
                case 9:
                    return 3;
                case 10:
                    return 4;
                case 11:
                    return 5;
                case 12:
                    return 5;
                case 13:
                    return 5;
                case 14:
                    return 5;
                case 15:
                    return 5;
                case 16:
                    return 5;
                case 17:
                    return 5;
                case 18:
                    return 5;
                case 19:
                    return 5;
                case 20:
                    return 5;
                default:
                    return 0;
            }
        }

        int calculo(string value) {
            int valueInt = Int32.Parse(value);
            int maxValue = 0;
            switch (comboBox2.Text) {
                case "Iniciado":
                    maxValue = 5;
                    break;
                case "Avanzado":
                    maxValue = 6;
                    break;
                case "Veterano":
                    maxValue = 8;
                    break;
                case "Experto":
                    maxValue = 10;
                    break;
                case "Maestro":
                    maxValue = 12;
                    break;
                case "Líder":
                    maxValue = 15;
                    break;
            }
            int aux = 1;
            int realValue = 0;
            for (int i = 1; i <= valueInt; i++) {
                aux = 1;
                if (i > maxValue) {
                    aux = 2;
                }
                realValue += cost(i) * aux;
            }
            return realValue;
        }

        void setPointsSpent() {
            int total, combat, phisical, knowledges, mental, speciality, magics, extra;
            combat = Int32.Parse(textBox64.Text);
            phisical = Int32.Parse(textBox63.Text);
            knowledges = Int32.Parse(textBox62.Text);
            mental = Int32.Parse(textBox61.Text);
            speciality = Int32.Parse(textBox60.Text);
            magics = Int32.Parse(textBox59.Text);
            extra = Int32.Parse(textBox58.Text);
            total = combat + phisical + knowledges + mental + speciality + magics + extra;
            textBox65.Text = total.ToString();
        }

        void setSpentMagicPoints() {
            int total = arcaneTotal + elementalTotal + divineTotal + runicTotal;
            textBox59.Text = total.ToString();
        }

        void setSpentArcane() {
            arcaneTotal = arcanePureTotal + arcaneCommonTotal + arcaneForbiddenTotal;
        }

        void setSpentDivine() {
            divineTotal = divineLightTotal + divineShadowTotal + divineOldGodTotal;
        }

        void setSpentElemental() {
            elementalTotal = elementalDruidTotal + elementalShamanTotal;
        }

        Boolean checkScience() {
            Boolean subKnowledgeOk = false;
            scienceTotal = Int32.Parse(textBox115.Text) + Int32.Parse(textBox113.Text) + Int32.Parse(textBox114.Text);
            if ((Int32.Parse(textBox40.Text) >= 3)) {
                if (Int32.Parse(textBox115.Text) > 0 && Int32.Parse(textBox113.Text) > 0 && Int32.Parse(textBox114.Text) > 0) {
                    if (scienceTotal == (3 + ((Int32.Parse(textBox40.Text) % 3)) * 2)) {
                        subKnowledgeOk = true;
                    }
                }
            }
            return subKnowledgeOk;
        }

        Boolean checkEtiquette() {
            Boolean subKnowledgeOk = false;
            etiqueteTotal = Int32.Parse(textBox130.Text) + Int32.Parse(textBox129.Text) + Int32.Parse(textBox128.Text);
            if ((Int32.Parse(textBox39.Text) >= 3)) {
                if (Int32.Parse(textBox130.Text) > 0 && Int32.Parse(textBox129.Text) > 0 && Int32.Parse(textBox128.Text) > 0) {
                    if (etiqueteTotal == (3 + ((Int32.Parse(textBox39.Text) % 3)) * 2)) {
                        subKnowledgeOk = true;
                    }
                }
            }
            return subKnowledgeOk;
        }

        Boolean checkNature() {
            Boolean subKnowledgeOk = false;
            natureTotal = Int32.Parse(textBox139.Text) + Int32.Parse(textBox138.Text) + Int32.Parse(textBox137.Text);
            if ((Int32.Parse(textBox38.Text) >= 3)) {
                if (Int32.Parse(textBox139.Text) > 0 && Int32.Parse(textBox138.Text) > 0 && Int32.Parse(textBox137.Text) > 0) {
                    if (natureTotal == (3 + ((Int32.Parse(textBox38.Text) % 3)) * 2)) {
                        subKnowledgeOk = true;
                    }
                }
            }
            return subKnowledgeOk;
        }

        Boolean checkHistory() {
            Boolean subKnowledgeOk = false;
            historyTotal = Int32.Parse(textBox118.Text) + Int32.Parse(textBox116.Text) + Int32.Parse(textBox117.Text);
            if ((Int32.Parse(textBox38.Text) >= 3)) {
                if (Int32.Parse(textBox118.Text) > 0 && Int32.Parse(textBox116.Text) > 0 && Int32.Parse(textBox117.Text) > 0) {
                    if (historyTotal == (3 + ((Int32.Parse(textBox39.Text) % 3)) * 2)) {
                        subKnowledgeOk = true;
                    }
                }
            }
            return subKnowledgeOk;
        }

        Boolean checkArts() {
            Boolean subKnowledgeOk = false;
            humanTotal = Int32.Parse(textBox127.Text) + Int32.Parse(textBox126.Text) + Int32.Parse(textBox125.Text);
            if ((Int32.Parse(textBox37.Text) >= 3)) {
                if (Int32.Parse(textBox127.Text) > 0 && Int32.Parse(textBox126.Text) > 0 && Int32.Parse(textBox125.Text) > 0) {
                    if (humanTotal == (3 + ((Int32.Parse(textBox37.Text) % 3)) * 2)) {
                        subKnowledgeOk = true;
                    }
                }
            }
            return subKnowledgeOk;
        }

        Boolean checkMedicine() {
            Boolean subKnowledgeOk = false;
            medicineTotal = Int32.Parse(textBox136.Text) + Int32.Parse(textBox135.Text) + Int32.Parse(textBox134.Text);
            if ((Int32.Parse(textBox36.Text) >= 3)) {
                if (Int32.Parse(textBox136.Text) > 0 && Int32.Parse(textBox135.Text) > 0 && Int32.Parse(textBox134.Text) > 0) {
                    if (medicineTotal == (3 + ((Int32.Parse(textBox36.Text) % 3)) * 2)) {
                        subKnowledgeOk = true;
                    }
                }
            }
            return subKnowledgeOk;
        }

        Boolean checkArtOfWar() {
            Boolean subKnowledgeOk = false;
            artOfWarTotal = Int32.Parse(textBox121.Text) + Int32.Parse(textBox120.Text) + Int32.Parse(textBox119.Text);
            if ((Int32.Parse(textBox35.Text) >= 3)) {
                if (Int32.Parse(textBox121.Text) > 0 && Int32.Parse(textBox120.Text) > 0 && Int32.Parse(textBox119.Text) > 0) {
                    if (artOfWarTotal == (3 + ((Int32.Parse(textBox34.Text) % 3)) * 2)) {
                        subKnowledgeOk = true;
                    }
                }
            }
            return subKnowledgeOk;
        }

        Boolean checkSurvival() {
            Boolean subKnowledgeOk = false;
            survivalTotal = Int32.Parse(textBox124.Text) + Int32.Parse(textBox123.Text) + Int32.Parse(textBox122.Text);
            if ((Int32.Parse(textBox31.Text) >= 3)) {
                if (Int32.Parse(textBox124.Text) > 0 && Int32.Parse(textBox123.Text) > 0 && Int32.Parse(textBox122.Text) > 0) {
                    if (survivalTotal == (3 + ((Int32.Parse(textBox31.Text) % 3)) * 2)) {
                        subKnowledgeOk = true;
                    }
                }
            }
            return subKnowledgeOk;
        }

        Boolean checkNavigation() {
            Boolean subKnowledgeOk = false;
            navigationTotal = Int32.Parse(textBox133.Text) + Int32.Parse(textBox132.Text) + Int32.Parse(textBox131.Text);
            if ((Int32.Parse(textBox100.Text) >= 3)) {
                if (Int32.Parse(textBox133.Text) > 0 && Int32.Parse(textBox132.Text) > 0 && Int32.Parse(textBox131.Text) > 0) {
                    if (navigationTotal == (3 + ((Int32.Parse(textBox100.Text) % 3)) * 2)) {
                        subKnowledgeOk = true;
                    }
                }
            }
            return subKnowledgeOk;
        }

        private string createFicha() {
            string fileString = "";
            fileString += "[color=#FFBF00][b]- Nombre: [/b][/color][COLOR=White]" + textBox1.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFBF00][b]- Raza: [/b][/color][COLOR=White]" + comboBox3.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFBF00][b]- Edad: [/b][/color][COLOR=White]" + textBox3.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFBF00][b]- Alineamiento: [/b][/color][COLOR=White]" + comboBox1.Text + "[/COLOR] " + "\r\n";
            fileString += "\r\n";
            fileString += "[color=#FFBF00][b]- Profesión: [/b][/color][COLOR=White]" + textBox4.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFBF00][b]- Estamento: [/b][/color][COLOR=White]" + comboBox2.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFBF00][b]- Usuario: [/b][/color][COLOR=White]" + textBox6.Text + "[/COLOR] " + "\r\n";
            fileString += "\r\n";
            fileString += "[color=#FFBF00][b]- Puntos de Experiencia: [/b][/color][COLOR=White]" + "0" + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFBF00][b]- Puntos de Experiencia Gastados: [/b][/color][COLOR=White]" + (Int32.Parse(textBox65.Text) - minPH).ToString() + "[/COLOR] " + "\r\n";

            fileString += "\r\n";
            fileString += "[IMG]" + textBox5.Text + "[/IMG]";
            fileString += "\r\n";
            fileString += "[color=#FFBF00][b]- Caracteristicas: [/b][/color]" + "\r\n";
            fileString += "\r\n";
            fileString += "[color=#FFFF40]	- Fuerza: [/color][COLOR=White]" + textBox7.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFFF40]	- Agilidad: [/color][COLOR=White]" + textBox8.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFFF40]	- Aguante: [/color][COLOR=White]" + textBox9.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFFF40]	- Inteligencia: [/color][COLOR=White]" + textBox10.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFFF40]	- Espiritu: [/color][COLOR=White]" + textBox11.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFFF40]	- Voluntad: [/color][COLOR=White]" + textBox12.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFFF40]	- Percepcion: [/color][COLOR=White]" + textBox13.Text + "[/COLOR] " + "\r\n";


            fileString += "\r\n";
            fileString += "\r\n";
            fileString += "[color=#FFBF00][b]- Habilidades: [/b][/color]" + "\r\n";
            fileString += "\r\n";
            fileString += "[color=#FFFF40][b]-COMBATE: [/b][/color]" + "\r\n";
            fileString += "\r\n";
            fileString += "[color=#FFFF40]- Arcos(PER): [/color][COLOR=White]" + textBox16.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFFF40]- Armas Arrojadizas(PER): [/color][COLOR=White]" + textBox25.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFFF40]- Armas de Fuego(PER): [/color][COLOR=White]" + textBox24.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFFF40]- Armas de Asta(AGI): [/color][COLOR=White]" + textBox23.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFFF40]- Armas Ligeras(AGI): [/color][COLOR=White]" + textBox22.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFFF40]- Armas Medias(FUE): [/color][COLOR=White]" + textBox21.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFFF40]- Armas Pesadas(FUE): [/color][COLOR=White]" + textBox20.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFFF40]- Ballestas(PER): [/color][COLOR=White]" + textBox19.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFFF40]- Sin Armas(FUE/AGI): [/color][COLOR=White]" + textBox18.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFFF40]- Escudos(FUE): [/color][COLOR=White]" + textBox17.Text + "[/COLOR] " + "\r\n";

            fileString += "\r\n";
            fileString += "[color=#FFFF40][b]-FISICAS: [/b][/color]" + "\r\n";
            fileString += "\r\n";
            fileString += "[color=#FFFF40]- Atletismo(AGI): [/color][COLOR=White]" + textBox30.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFFF40]- Advertir(PER): [/color][COLOR=White]" + textBox29.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFFF40]- Resistencia(AGU): [/color][COLOR=White]" + textBox28.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFFF40]- Montar(AGI): [/color][COLOR=White]" + textBox27.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFFF40]- Proezas(FUE): [/color][COLOR=White]" + textBox26.Text + "[/COLOR] " + "\r\n";

            fileString += "\r\n";
            fileString += "[color=#FFFF40][b]-CONOCIMIENTOS: [/b][/color]" + "\r\n";
            fileString += "\r\n";
            fileString += "[color=#FFFF40]- Ciencia(INT): [/color][COLOR=White]" + textBox40.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFFF40]- Etiqueta y Heraldica(INT): [/color][COLOR=White]" + textBox39.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFFF40]- Flora y Fauna(INT): [/color][COLOR=White]" + textBox38.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFFF40]- Historia y Geografia(INT): [/color][COLOR=White]" + textBox37.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFFF40]- Humanidades(INT): [/color][COLOR=White]" + textBox36.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFFF40]- Medicina(INT): [/color][COLOR=White]" + textBox35.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFFF40]- Arte de la Guerra(INT): [/color][COLOR=White]" + textBox34.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFFF40]- Ciencias de lo Arcano(INT): [/color][COLOR=White]" + textBox33.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFFF40]- Ciencias de lo Prohibido(INT): [/color][COLOR=White]" + textBox32.Text + "[/COLOR] " + "\r\n";
            fileString += "[color=#FFFF40]- Supervivencia(INT): [/color][COLOR=White]" + textBox31.Text + "[/COLOR] " + "\r\n";
            fileString += "[COLOR=#FFFF40]- Religión ([/COLOR][COLOR=White]" + textBox56.Text + "[/COLOR][COLOR=#FFFF40]) (INT):[/COLOR][COLOR=White]" + textBox52.Text + "[/COLOR] " + "\r\n";
            if (textBox52.Text != "") fileString += "[COLOR=#FFFF40]- Vínculo ([/COLOR][COLOR=White]" + textBox110.Text + "[/COLOR][COLOR=#FFFF40]) (INT):[/COLOR][COLOR=White]" + textBox111.Text + "[/COLOR] " + "\r\n";
            if (textBox112.Text != "") fileString += "[COLOR=#FFFF40]- Rúnico(INT):[/COLOR][COLOR=White]" + textBox112.Text + "[/COLOR] " + "\r\n";

            fileString += "\r\n";
            fileString += "[COLOR=#FFFF40][b]- MENTALES[/b][/COLOR] " + "\r\n";
            fileString += "\r\n";
            fileString += "[COLOR=#FFFF40]- Concentración (VOL): [/COLOR][COLOR=White]" + textBox41.Text + "[/COLOR] " + "\r\n";
            fileString += "[COLOR=#FFFF40]- Diplomacia (INT): [/COLOR][COLOR=White]" + textBox42.Text + "[/COLOR] " + "\r\n";
            fileString += "[COLOR=#FFFF40]- Empatía (ESP): [/COLOR][COLOR=White]" + textBox43.Text + "[/COLOR] " + "\r\n";
            fileString += "[COLOR=#FFFF40]- Frialdad (VOL): [/COLOR][COLOR=White]" + textBox44.Text + "[/COLOR] " + "\r\n";
            fileString += "[COLOR=#FFFF40]- Sensibilidad Mágica (ESP): [/COLOR][COLOR=White]" + textBox45.Text + "[/COLOR] " + "\r\n";
            fileString += "[COLOR=#FFFF40]- Subterfugio (INT): [/COLOR][COLOR=White]" + textBox51.Text + "[/COLOR] " + "\r\n" + "\r\n";

            fileString += "\r\n";
            fileString += "[COLOR=#FFFF40][b]- ESPECIALIDADES[/b][/COLOR] " + "\r\n";
            fileString += "\r\n";
            fileString += "[COLOR=#FFFF40]- Arte ([/COLOR][COLOR=White]" + textBox57.Text + "[/COLOR][COLOR=#FFFF40]):[/COLOR][COLOR=White]" + textBox46.Text + "[/COLOR] " + "\r\n";
            fileString += "[COLOR=#FFFF40]- Disfrazarse (INT): [/COLOR][COLOR=White]" + textBox47.Text + "[/COLOR] " + "\r\n";
            fileString += "[COLOR=#FFFF40]- Manipular mecanismos (INT): [/COLOR][COLOR=White]" + textBox48.Text + "[/COLOR] " + "\r\n";
            fileString += "[COLOR=#FFFF40]- Juego de manos (AGI): [/COLOR][COLOR=White]" + textBox49.Text + "[/COLOR] " + "\r\n";
            fileString += "[COLOR=#FFFF40]- Oficio ([/COLOR][COLOR=White]" + textBox58.Text + "[/COLOR][COLOR=#FFFF40]):[/COLOR][COLOR=White]" + textBox50.Text + "[/COLOR] " + "\r\n";
            fileString += "[COLOR=#FFFF40]- Pilotar (INT): [/COLOR][COLOR=White]" + textBox53.Text + "[/COLOR] " + "\r\n";
            fileString += "[COLOR=#FFFF40]- Rastreo (PER): [/COLOR][COLOR=White]" + textBox54.Text + "[/COLOR] " + "\r\n";
            fileString += "[COLOR=#FFFF40]- Sigilo (AGI): [/COLOR][COLOR=White]" + textBox55.Text + "[/COLOR] " + "\r\n" + "\r\n";

            // ARCANO
            if (arcaneTotal > 0) {
                fileString += "[COLOR=#FFFF40][b]- MAGIA ARCANA[/b][/COLOR]" + "\r\n" + "\r\n";
                //PURA
                if (arcanePureTotal > 0) {
                    fileString += "[COLOR=#FFBF00][b]- PURA[/b][/COLOR]" + "\r\n";
                    if (checkBox8.Checked) {
                        fileString += "[COLOR=#FFFF40]- [COMP]Abjuración (INT): [/COLOR][COLOR=White]" + textBox77.Text + "[/COLOR]" + "\r\n";
                    } else {
                        fileString += "[COLOR=#FFFF40]- Abjuración (INT): [/COLOR][COLOR=White]" + textBox77.Text + "[/COLOR]" + "\r\n";
                    }
                    if (checkBox9.Checked) {
                        fileString += "[COLOR=#FFFF40]-[COMP] Adivinación (INT): [/COLOR][COLOR=White]" + textBox78.Text + "[/COLOR] " + "\r\n";
                    } else {
                        fileString += "[COLOR=#FFFF40]- Adivinación (INT): [/COLOR][COLOR=White]" + textBox78.Text + "[/COLOR] " + "\r\n";
                    }
                    if (checkBox10.Checked) {
                        fileString += "[COLOR=#FFFF40]- [COMP]Conjuración (INT): [/COLOR][COLOR=White]" + textBox79.Text + "[/COLOR] " + "\r\n";
                    } else {
                        fileString += "[COLOR=#FFFF40]- Conjuración (INT): [/COLOR][COLOR=White]" + textBox79.Text + "[/COLOR] " + "\r\n";
                    }
                    if (checkBox11.Checked) {
                        fileString += "[COLOR=#FFFF40]- [COMP]Transmutación (INT): [/COLOR][COLOR=White]" + textBox80.Text + "[/COLOR] " + "\r\n" + "\r\n";
                    } else {
                        fileString += "[COLOR=#FFFF40]- Transmutación (INT): [/COLOR][COLOR=White]" + textBox80.Text + "[/COLOR] " + "\r\n" + "\r\n";
                    }
                }
                //COMUN
                if (arcaneCommonTotal > 0) {
                    fileString += "[COLOR=#FFBF00][b]- COMÚN[/b][/COLOR]" + "\r\n";
                    if (checkBox12.Checked) {
                        fileString += "[COLOR=#FFFF40]- [COMP]Evocación (INT): [/COLOR][COLOR=White]" + textBox81.Text + "[/COLOR] " + "\r\n";
                    } else {
                        fileString += "[COLOR=#FFFF40]- Evocación (INT): [/COLOR][COLOR=White]" + textBox81.Text + "[/COLOR] " + "\r\n";
                    }
                    if (checkBox13.Checked) {
                        fileString += "[COLOR=#FFFF40]- [COMP]Ilusionismo (INT): [/COLOR][COLOR=White]" + textBox76.Text + "[/COLOR] " + "\r\n";
                    } else {
                        fileString += "[COLOR=#FFFF40]- Ilusionismo (INT): [/COLOR][COLOR=White]" + textBox76.Text + "[/COLOR] " + "\r\n";
                    }
                    if (checkBox14.Checked) {
                        fileString += "[COLOR=#FFFF40]- [COMP]Mentalismo (INT): [/COLOR][COLOR=White]" + textBox82.Text + "[/COLOR] " + "\r\n";
                    } else {
                        fileString += "[COLOR=#FFFF40]- Mentalismo (INT): [/COLOR][COLOR=White]" + textBox82.Text + "[/COLOR] " + "\r\n";
                    }
                }
                // ARCANO OSCURA
                if (arcaneForbiddenTotal > 0) {
                    fileString += "\r\n";
                    fileString += "[COLOR=#FFBF00 ][b]- PROHIBIDA[/b][/COLOR] " + "\r\n";
                    if (checkBox12.Checked) {
                        fileString += "[COLOR=#FFFF40]- [COMP]Evocación (INT): [/COLOR][COLOR=White]" + textBox81.Text + "[/COLOR] " + "\r\n";
                    } else {
                        fileString += "[COLOR=#FFFF40]- Evocación (INT): [/COLOR][COLOR=White]" + textBox81.Text + "[/COLOR] " + "\r\n";
                    }
                    if (checkBox13.Checked) {
                        fileString += "[COLOR=#FFFF40]- [COMP]Ilusionismo (INT): [/COLOR][COLOR=White]" + textBox76.Text + "[/COLOR] " + "\r\n";
                    } else {
                        fileString += "[COLOR=#FFFF40]- Ilusionismo (INT): [/COLOR][COLOR=White]" + textBox76.Text + "[/COLOR] " + "\r\n";
                    }
                    if (checkBox14.Checked) {
                        fileString += "[COLOR=#FFFF40]- [COMP]Mentalismo (INT): [/COLOR][COLOR=White]" + textBox82.Text + "[/COLOR] " + "\r\n";
                    } else {
                        fileString += "[COLOR=#FFFF40]- Mentalismo (INT): [/COLOR][COLOR=White]" + textBox82.Text + "[/COLOR] " + "\r\n";
                    }
                    if (checkBox15.Checked) {
                        fileString += "[COLOR=#FFFF40]- [COMP]Nigromancia (INT): [/COLOR][COLOR=White]" + textBox72.Text + "[/COLOR] " + "\r\n";
                    } else {
                        fileString += "[COLOR=#FFFF40]- Nigromancia (INT): [/COLOR][COLOR=White]" + textBox72.Text + "[/COLOR] " + "\r\n";
                    }
                    if (checkBox16.Checked) {
                        fileString += "[COLOR=#FFFF40]- [COMP]Demonología (INT): [/COLOR][COLOR=White]" + textBox73.Text + "[/COLOR] " + "\r\n";
                    } else {
                        fileString += "[COLOR=#FFFF40]- Demonología (INT): [/COLOR][COLOR=White]" + textBox73.Text + "[/COLOR] " + "\r\n";
                    }
                    if (checkBox17.Checked) {
                        fileString += "[COLOR=#FFFF40]- [COMP]Obtenebración (INT): [/COLOR][COLOR=White]" + textBox74.Text + "[/COLOR] " + "\r\n";
                    } else {
                        fileString += "[COLOR=#FFFF40]- Obtenebración (INT): [/COLOR][COLOR=White]" + textBox74.Text + "[/COLOR] " + "\r\n";
                    }
                    if (checkBox18.Checked) {
                        fileString += "[COLOR=#FFFF40]* [COMP]Sanguinomancia (INT): [/COLOR][COLOR=White]" + textBox75.Text + "[/COLOR] " + "\r\n" + "\r\n" + "\r\n";
                    } else {
                        fileString += "[COLOR=#FFFF40]* Sanguinomancia (INT): [/COLOR][COLOR=White]" + textBox75.Text + "[/COLOR] " + "\r\n" + "\r\n" + "\r\n";
                    }
                }
            }
            // ELEMENTAL
            else if (elementalShamanTotal > 0) {
                fileString += "[COLOR=#FFFF40][b]- MAGIA ELEMENTAL[/b][/COLOR]" + "\r\n" + "\r\n";
                if (checkBox27.Checked) {
                    fileString += "[COLOR=#FFFF40]- [COMP]Fuego (ESP): [/COLOR][COLOR=White]" + textBox83.Text + "[/COLOR] " + "\r\n";
                } else {
                    fileString += "[COLOR=#FFFF40]- Fuego (ESP): [/COLOR][COLOR=White]" + textBox83.Text + "[/COLOR] " + "\r\n";
                }
                if (checkBox24.Checked) {
                    fileString += "[COLOR=#FFFF40]- [COMP]Tierra (ESP): [/COLOR][COLOR=White]" + textBox84.Text + "[/COLOR] " + "\r\n";
                } else {
                    fileString += "[COLOR=#FFFF40]- Tierra (ESP): [/COLOR][COLOR=White]" + textBox84.Text + "[/COLOR] " + "\r\n";
                }
                if (checkBox26.Checked) {
                    fileString += "[COLOR=#FFFF40]- [COMP]Aire (ESP): [/COLOR][COLOR=White]" + textBox85.Text + "[/COLOR]" + "\r\n";
                } else {
                    fileString += "[COLOR=#FFFF40]- Aire (ESP): [/COLOR][COLOR=White]" + textBox85.Text + "[/COLOR]" + "\r\n";
                }
                if (checkBox25.Checked) {
                    fileString += "[COLOR=#FFFF40]- [COMP]Agua (ESP): [/COLOR][COLOR=White]" + textBox86.Text + "[/COLOR] " + "\r\n";
                } else {
                    fileString += "[COLOR=#FFFF40]- Agua (ESP): [/COLOR][COLOR=White]" + textBox86.Text + "[/COLOR] " + "\r\n";
                }
                if (checkBox28.Checked) {
                    fileString += "[COLOR=#FFFF40]- [COMP]Espiritismo (ESP): [/COLOR][COLOR=White]" + textBox87.Text + "[/COLOR] " + "\r\n";
                } else {
                    fileString += "[COLOR=#FFFF40]- Espiritismo (ESP): [/COLOR][COLOR=White]" + textBox87.Text + "[/COLOR] " + "\r\n";
                }
            }
            //NATURAL
            else if (elementalDruidTotal > 0) {
                fileString += "[COLOR=#FFFF40][b]- MAGIA NATURAL[/b][/COLOR]" + "\r\n" + "\r\n";
                if (checkBox19.Checked) {
                    fileString += "[COLOR=#FFFF40]- [COMP]Naturaleza (ESP): [/COLOR][COLOR=White]" + textBox67.Text + "[/COLOR] " + "\r\n";
                } else {
                    fileString += "[COLOR=#FFFF40]- Naturaleza (ESP): [/COLOR][COLOR=White]" + textBox67.Text + "[/COLOR] " + "\r\n";
                }
                if (checkBox20.Checked) {
                    fileString += "[COLOR=#FFFF40]- [COMP]Primalismo (VOL): [/COLOR][COLOR=White]" + textBox68.Text + "[/COLOR] " + "\r\n" + "\r\n" + "\r\n";
                } else {
                    fileString += "[COLOR=#FFFF40]- Primalismo (VOL): [/COLOR][COLOR=White]" + textBox68.Text + "[/COLOR] " + "\r\n" + "\r\n" + "\r\n";
                }
                if (checkBox21.Checked) {
                    fileString += "[COLOR=#FFFF40]- [COMP]Aire (ESP): [/COLOR][COLOR=White]" + textBox69.Text + "[/COLOR]" + "\r\n";
                } else {
                    fileString += "[COLOR=#FFFF40]- Aire (ESP): [/COLOR][COLOR=White]" + textBox69.Text + "[/COLOR]" + "\r\n";
                }
                if (checkBox22.Checked) {
                    fileString += "[COLOR=#FFFF40]- [COMP]Agua (ESP): [/COLOR][COLOR=White]" + textBox70.Text + "[/COLOR] " + "\r\n";
                } else {
                    fileString += "[COLOR=#FFFF40]- Agua (ESP): [/COLOR][COLOR=White]" + textBox70.Text + "[/COLOR] " + "\r\n";
                }
                if (checkBox23.Checked) {
                    fileString += "[COLOR=#FFFF40]- [COMP]Tierra (ESP): [/COLOR][COLOR=White]" + textBox71.Text + "[/COLOR] " + "\r\n";
                } else {
                    fileString += "[COLOR=#FFFF40]- Tierra (ESP): [/COLOR][COLOR=White]" + textBox71.Text + "[/COLOR] " + "\r\n";
                }
            }
            //Magia DIVINA(LUZ)
            else if (divineLightTotal > 0) {
                fileString += "[COLOR=#FFFF40][b]- MAGIA DIVINA[/b][/COLOR] " + "\r\n" + "\r\n";
                fileString += "[COLOR=#FFFF40]- Consagración (VOL): [/COLOR][COLOR=White]" + textBox88.Text + "[/COLOR] " + "\r\n";
                fileString += "[COLOR=#FFFF40]- Reprensión (VOL): [/COLOR][COLOR=White]" + textBox89.Text + "[/COLOR] " + "\r\n";
                fileString += "[COLOR=#FFFF40]- Serenidad (VOL): [/COLOR][COLOR=White]" + textBox90.Text + "[/COLOR] " + "\r\n";
            }
            //Magia DIVINA(SOMBRA)
            else if (divineShadowTotal > 0) {
                fileString += "[COLOR=#FFFF40][b]- MAGIA DIVINA[/b][/COLOR] " + "\r\n" + "\r\n";
                fileString += "[COLOR=#FFFF40]- Dominación (VOL): [/COLOR][COLOR=White]" + textBox92.Text + "[/COLOR] " + "\r\n";
                fileString += "[COLOR=#FFFF40]- Extinción (VOL): [/COLOR][COLOR=White]" + textBox93.Text + "[/COLOR] " + "\r\n";
                fileString += "[COLOR=#FFFF40]- Mortificación (VOL): [/COLOR][COLOR=White]" + textBox94.Text + "[/COLOR] " + "\r\n";
            }
            //Magia DIVINA(DIOSES ANT.)
            else if (divineOldGodTotal > 0) {
                fileString += "[COLOR=#FFFF40][b]- MAGIA DIVINA[/b][/COLOR] " + "\r\n" + "\r\n";
                fileString += "[COLOR=#FFFF40]- Entropía (VOL): [/COLOR][COLOR=White]" + textBox95.Text + "[/COLOR] " + "\r\n";
                fileString += "[COLOR=#FFFF40]- Caos (VOL): [/COLOR][COLOR=White]" + textBox91.Text + "[/COLOR] " + "\r\n";
                fileString += "[COLOR=#FFFF40]- Locura (VOL): [/COLOR][COLOR=White]" + textBox99.Text + "[/COLOR] " + "\r\n";
            }
            //Magia Caballeros de la Muerte
            else if (runicTotal > 0) {
                fileString += "[COLOR=#FFFF40][b]- MAGIA de HojaRuna[/b][/COLOR] " + "\r\n" + "\r\n";
                fileString += "[COLOR=#FFFF40]- Profano (VOL): [/COLOR][COLOR=White]" + textBox96.Text + "[/COLOR] " + "\r\n";
                fileString += "[COLOR=#FFFF40]- Escarcha (ESP): [/COLOR][COLOR=White]" + textBox97.Text + "[/COLOR] " + "\r\n";
                fileString += "[COLOR=#FFFF40]- Sangre (VOL): [/COLOR][COLOR=White]" + textBox98.Text + "[/COLOR] " + "\r\n";
                fileString += "[COLOR=#FFFF40]- Oscuridad (ESP): [/COLOR][COLOR=White]" + textBox109.Text + "[/COLOR] " + "\r\n";
            }
            //SUBCONOCIMIENTOS
            fileString += "[b][color=#FFBF00]- Conocimientos: [/color][/b][spoiler]" + "\r\n" + "\r\n";
            fileString += "[color=#FFFF40]- Ciencia(INT): [/color][color=White]" + textBox40.Text + "[/color]" + "\r\n";
            fileString += "[list] [*] Física: " + textBox113.Text + "\r\n";
            fileString += "[*] Química: " + textBox114.Text + "\r\n";
            fileString += "[*] Tecnología: " + textBox115.Text + "[/list]" + "\r\n";
            fileString += "[color=#FFFF40]- Etiqueta y Heraldica(INT): [/color][color=White]" + textBox39.Text + "[/color]" + "\r\n";
            fileString += "[list] [*] Protocolo: " + textBox130.Text + "\r\n";
            fileString += "[*] Nobleza: " + textBox129.Text + "\r\n";
            fileString += "[*] Sociedad: " + textBox128.Text + "[/list]" + "\r\n";
            fileString += "[color=#FFFF40]- Naturaleza(INT): [/color][color=White]" + textBox38.Text + "[/color]" + "\r\n";
            fileString += "[list] [*] Flora: " + textBox139.Text + "\r\n";
            fileString += "[*] Fauna: " + textBox138.Text + "\r\n";
            fileString += "[*] Geología: " + textBox137.Text + "[/list]" + "\r\n";
            fileString += "[color=#FFFF40]- Historia y Geografia(INT): [/color][color=White]" + textBox37.Text + "[/color]" + "\r\n";
            fileString += "[list] [*] Historia: " + textBox116.Text + "\r\n";
            fileString += "[*] Topografía: " + textBox117.Text + "\r\n";
            fileString += "[*] Geografía regional: " + textBox118.Text + "[/list]" + "\r\n";
            fileString += "[color=#FFFF40]- Humanidades(INT): [/color][color=White]" + textBox36.Text + "[/color]" + "\r\n";
            fileString += "[list] [*] Idiomas[" + textBox140.Text + "]: " + textBox127.Text + "\r\n";
            fileString += "[*] Arte: " + textBox126.Text + "\r\n";
            fileString += "[*] Cultura: " + textBox125.Text + "[/list]" + "\r\n";
            fileString += "[color=#FFFF40]- Medicina(INT): [/color][color=White]" + textBox35.Text + "[/color]" + "\r\n";
            fileString += "[list] [*] Anatomía: " + textBox136.Text + "" + "\r\n";
            fileString += "[*] Psicología: " + textBox135.Text + "\r\n";
            fileString += "[*] Patologías: " + textBox134.Text + "[/list]" + "\r\n";
            fileString += "[color=#FFFF40]- Arte de la Guerra(INT): [/color][color=White]" + textBox34.Text + "[/color]" + "\r\n";
            fileString += "[list] [*] Estrategia: " + textBox121.Text + "\r\n";
            fileString += "[*] Logística: " + textBox120.Text + "\r\n";
            fileString += "[*] Armamento: " + textBox119.Text + "[/list]" + "\r\n";
            fileString += "[color=#FFFF40]- Supervivencia(INT): [/color][color=White]" + textBox31.Text + "[/color]" + "\r\n";
            fileString += "[list] [*] Técnicas: " + textBox124.Text + "\r\n";
            fileString += "[*] Seguridad: " + textBox123.Text + "\r\n";
            fileString += "[*] Alimentación: " + textBox122.Text + "[/list]" + "\r\n";
            fileString += "[color=#FFFF40]- Navegación(INT): [/color][color=White]" + textBox100.Text + "[/color]" + "\r\n";
            fileString += "[list][*] Teoría naval: " + textBox133.Text + "\r\n";
            fileString += "[*] Embarcaciones: " + textBox132.Text + "\r\n";
            fileString += "[*] Geografía marina: " + textBox131.Text + "[/list]" + "\r\n";
            fileString += "[/spoiler]";

            fileString += "\r\n";
            fileString += "[B][COLOR=#FFBF00]- Recompensas: [/COLOR][/B] " + "\r\n" + "\r\n";
            fileString += "[B][COLOR=#FFBF00]- Recompensas por PX: [/COLOR][/B] " + "\r\n" + "\r\n";
            fileString += "[B][COLOR=#FFBF00]- Posición: [/COLOR][/B] " + "\r\n" + "\r\n";
            fileString += "[B][COLOR=#FFBF00]- Posesiones: [/COLOR][/B] " + "\r\n" + "\r\n";
            fileString += "[B][COLOR=#FFBF00]- Contactos: [/COLOR][/B] " + "\r\n" + "\r\n";
            fileString += "[B][COLOR=#FFBF00]- Trasfondos: [/COLOR][/B] " + "\r\n" + "\r\n";
            fileString += "[B][COLOR=#FFBF00]- Ventajas/ Desventajas: [/COLOR][/B] " + "\r\n" + "\r\n";
            return fileString;
        }

        private void ConfirmBasicData(object sender, EventArgs e) {
            if (textBox1.Text.Equals("") || comboBox2.Text.Equals("") || comboBox3.Text.Equals("")) {
                MessageBox.Show("Error. Inserta el nombre, la raza y el estamento de tu personaje para continuar.", "Error.", MessageBoxButtons.OK);
                return;
            }
            switch (comboBox2.Text) {
                case "Iniciado":
                    textBox65.Text = (minPH).ToString();
                    minPC = 41;
                    maxPC = 42;
                    break;
                case "Avanzado":
                    textBox65.Text = (minPH + 25).ToString();
                    minPC = 42;
                    maxPC = 43;
                    break;
                case "Veterano":
                    textBox65.Text = (minPH + 50).ToString();
                    minPC = 43;
                    maxPC = 44;
                    break;
                case "Experto":
                    textBox65.Text = (minPH + 100).ToString();
                    minPC = 44;
                    maxPC = 45;
                    break;
                case "Maestro":
                    textBox65.Text = (minPH + 175).ToString();
                    minPC = 45;
                    maxPC = 46;
                    break;
                case "Líder":
                    textBox65.Text = (minPH + 250).ToString();
                    minPC = 46;
                    maxPC = 47;
                    break;
            }
            setMaxMin();
            textBox15.Text = minPC.ToString();
            if (!tabsAdded) {
                tabsAdded = true;
                /*this.tabControl1.TabPages.Add(this.tabPage2);
                this.tabControl1.TabPages.Add(this.tabPage3);
                this.tabControl1.TabPages.Add(this.tabPage4);
                this.tabControl1.TabPages.Add(this.tabPage5);
                this.tabControl1.TabPages.Add(this.tabPage6);
                this.tabControl1.TabPages.Add(this.tabPage7);
                this.tabControl1.TabPages.Add(this.tabPage8);
                this.tabControl1.TabPages.Add(this.tabPage9);
                this.tabControl1.TabPages.Add(this.tabPage11);
                this.tabControl1.TabPages.Add(this.tabPage10);
                this.tabControl1.TabPages.Add(this.tabPage12);
                this.tabControl1.TabPages.Add(this.tabPage13);*/
            }
        }

        private void setMaxMin() {
            //Comprobamos la raza seleccionada,
            //Dependiendo de la raza permitiremos unos min o unos max;
            switch (comboBox3.Text) {
                case "Humano":
                    maxmins = raceSelected.Human;
                    minPC = minPC < maxPC ? maxPC : minPC;
                    break;
                case "Orco":
                    maxmins = raceSelected.Orc;
                    break;
                case "Enano":
                    maxmins = raceSelected.Dwarf;
                    break;
                case "Tauren":
                    maxmins = raceSelected.Tauren;
                    break;
                case "Gnomo":
                    maxmins = raceSelected.Gnome;
                    break;
                case "Kal'dorei":
                    maxmins = raceSelected.Kaldorei;
                    break;
                case "Draenei":
                    maxmins = raceSelected.Draenei;
                    break;
                case "Sin'dorei":
                    maxmins = raceSelected.Sindorei;
                    break;
                case "Quel'dorei":
                    maxmins = raceSelected.Queldorei;
                    break;
                case "Goblin":
                    maxmins = raceSelected.Goblin;
                    break;
                case "Ogro":
                    maxmins = raceSelected.Ogre;
                    break;
                case "Troll":
                    maxmins = raceSelected.Troll;
                    minPC = minPC < maxPC ? maxPC : minPC;
                    break;
                case "Altonato":
                    maxmins = raceSelected.HighBorn;
                    break;
                case "Martillo Salvaje":
                    maxmins = raceSelected.WildHammer;
                    break;
                case "Hierro Negro":
                    maxmins = raceSelected.DarkIron;
                    break;
                case "Amani":
                    maxmins = raceSelected.AmaniDrakari;
                    minPC = minPC < maxPC ? maxPC : minPC;
                    break;
                case "Drakari":
                    maxmins = raceSelected.AmaniDrakari;
                    minPC = minPC < maxPC ? maxPC : minPC;
                    break;
                case "Zandalari":
                    maxmins = raceSelected.Zandalari;
                    minPC = minPC < maxPC ? maxPC : minPC;
                    break;
                case "Tábido":
                    maxmins = raceSelected.Tabid;
                    break;
                case "Vrykul":
                    maxmins = raceSelected.Vrykul;
                    break;
                case "Humano (No - Muerto)":
                    maxmins = raceSelected.HumanDeath;
                    minPC = minPC < maxPC ? maxPC : minPC;
                    break;
                case "Quel'dorei (No - Muerto)":
                    maxmins = raceSelected.Guthdorei;
                    break;
                case "Orco (No - Muerto)":
                    maxmins = raceSelected.OrcDeath;
                    break;
                case "Troll (No - Muerto)":
                    maxmins = raceSelected.TrollDeath;
                    minPC = minPC < maxPC ? maxPC : minPC;
                    break;
                case "Sin'dorei (Sangrevil)":
                    maxmins = raceSelected.SindoreiDemon;
                    break;
                case "Orco (Sangrevil)":
                    maxmins = raceSelected.OrcDemon;
                    break;
                case "Draenei (Sangrevil)":
                    maxmins = raceSelected.DraeneiDemon;
                    break;
                case "Kal'dorei (Sangrevil)":
                    maxmins = raceSelected.KaldoreiDemon;
                    break;
                case "Semielfo":
                    maxmins = raceSelected.Semielf;
                    break;
                case "Semiogro":
                    maxmins = raceSelected.Semiogre;
                    break;
                case "Semiorco":
                    maxmins = raceSelected.Semiorc;
                    break;
            }
        }

        private void SaveCharacteristics(object sender, EventArgs e) {
            Int32 strLocal, dexLocal, resLocal, intLocal, spLocal, willLocal, perLocal, pointsLeft;
            strLocal = Int32.Parse(textBox7.Text);
            dexLocal = Int32.Parse(textBox8.Text);
            resLocal = Int32.Parse(textBox9.Text);
            intLocal = Int32.Parse(textBox10.Text);
            spLocal = Int32.Parse(textBox11.Text);
            willLocal = Int32.Parse(textBox12.Text);
            perLocal = Int32.Parse(textBox13.Text);
            pointsLeft = minPC - strLocal - dexLocal - resLocal - spLocal - intLocal - willLocal - perLocal;
            textBox14.Text = pointsLeft.ToString();
            if (pointsLeft == 0) {
                //TODO: CHECK MAXMIN
                if ((maxmins.fueMax + 1 >= strLocal && maxmins.fueMin - 1 <= strLocal) &&
                (maxmins.agiMax + 1 >= dexLocal && maxmins.agiMin - 1 <= dexLocal) &&
                (maxmins.aguMax + 1 >= resLocal && maxmins.aguMin - 1 <= resLocal) &&
                (maxmins.intMax + 1 >= intLocal && maxmins.intMin - 1 <= intLocal) &&
                (maxmins.espMax + 1 >= spLocal && maxmins.espMin - 1 <= spLocal) &&
                (maxmins.volMax + 1 >= willLocal && maxmins.volMin - 1 <= willLocal) &&
                (maxmins.perMax + 1 >= perLocal && maxmins.perMin - 1 <= perLocal))
                    MessageBox.Show("Valores de Características Correctos.", "Características completadas.", MessageBoxButtons.OK);
                else {
                    MessageBox.Show("Los valores establecidos no cumplen el reglamento de máximos y mínimos.", "Características erroneas.", MessageBoxButtons.OK);
                }
            } else {
                MessageBox.Show("Revisa los puntos, hay un error.", "Error!.", MessageBoxButtons.OK);
            }
        }


        private void createTxt(object sender, EventArgs e) {
            string fileName = textBox1.Text + " (Ficha) .txt";
            StreamWriter sw = new StreamWriter(fileName);
            int total = Int32.Parse(textBox66.Text) - Int32.Parse(textBox65.Text);
            if (total == 0) {
                //Terminado, ficha done! Solo queda entregarlo todo.
                MessageBox.Show("Ficha Completa! En la misma carpeta donde se encuentra este programa, se ha creado un .txt con la ficha. Solo tienes que pegarla en la Solicitud de Cuenta!.", "Ficha Completa.", MessageBoxButtons.OK);
                sw.WriteLine(createFicha());
                sw.Close();
                Close();
            } else if (total < 0) {
                MessageBox.Show("Error. Revisa los puntajes, te faltan puntos por gastar.", "Error.", MessageBoxButtons.OK);

            } else {
                MessageBox.Show("Error. Revisa los puntajes, te sobran puntos en la ficha.", "Error.", MessageBoxButtons.OK);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e) {

        }
    }
}