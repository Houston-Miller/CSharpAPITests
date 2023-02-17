using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAPITests
{

    public class OverFastResponse
    {
        public Summary summary { get; set; }
        public Stats stats { get; set; }
    }

    public class Summary
    {
        public string username { get; set; }
        public string avatar { get; set; }
        public string title { get; set; }
        public Endorsement endorsement { get; set; }
        public object competitive { get; set; }
        public string privacy { get; set; }
    }

    public class Endorsement
    {
        public int level { get; set; }
        public string frame { get; set; }
    }

    public class Stats
    {
        public Pc pc { get; set; }
        public object console { get; set; }
    }

    public class Pc
    {
        public Quickplay quickplay { get; set; }
        public Competitive competitive { get; set; }
    }

    public class Quickplay
    {
        public Heroes_Comparisons heroes_comparisons { get; set; }
        public Career_Stats career_stats { get; set; }
    }

    public class Heroes_Comparisons
    {
        public Time_Played time_played { get; set; }
        public Games_Won games_won { get; set; }
        public Weapon_Accuracy weapon_accuracy { get; set; }
        public Eliminations_Per_Life eliminations_per_life { get; set; }
        public Critical_Hit_Accuracy critical_hit_accuracy { get; set; }
        public Multikill_Best multikill_best { get; set; }
        public Objective_Kills objective_kills { get; set; }
        public object win_percentage { get; set; }
    }

    public class Time_Played
    {
        public string label { get; set; }
        public Value[] values { get; set; }
    }

    public class Value
    {
        public string hero { get; set; }
        public int value { get; set; }
    }

    public class Games_Won
    {
        public string label { get; set; }
        public Value1[] values { get; set; }
    }

    public class Value1
    {
        public string hero { get; set; }
        public int value { get; set; }
    }

    public class Weapon_Accuracy
    {
        public string label { get; set; }
        public Value2[] values { get; set; }
    }

    public class Value2
    {
        public string hero { get; set; }
        public int value { get; set; }
    }

    public class Eliminations_Per_Life
    {
        public string label { get; set; }
        public Value3[] values { get; set; }
    }

    public class Value3
    {
        public string hero { get; set; }
        public float value { get; set; }
    }

    public class Critical_Hit_Accuracy
    {
        public string label { get; set; }
        public Value4[] values { get; set; }
    }

    public class Value4
    {
        public string hero { get; set; }
        public int value { get; set; }
    }

    public class Multikill_Best
    {
        public string label { get; set; }
        public Value5[] values { get; set; }
    }

    public class Value5
    {
        public string hero { get; set; }
        public int value { get; set; }
    }

    public class Objective_Kills
    {
        public string label { get; set; }
        public Value6[] values { get; set; }
    }

    public class Value6
    {
        public string hero { get; set; }
        public int value { get; set; }
    }

    public class Career_Stats
    {
        public AllHeroes[] allheroes { get; set; }
        public Ana[] ana { get; set; }
        public Ashe[] ashe { get; set; }
        public Baptiste[] baptiste { get; set; }
        public Bastion[] bastion { get; set; }
        public Brigitte[] brigitte { get; set; }
        public Cassidy[] cassidy { get; set; }
        public Dva[] dva { get; set; }
        public Doomfist[] doomfist { get; set; }
        public Echo[] echo { get; set; }
        public Genji[] genji { get; set; }
        public Hanzo[] hanzo { get; set; }
        public JunkerQueen[] junkerqueen { get; set; }
        public Junkrat[] junkrat { get; set; }
        public Kiriko[] kiriko { get; set; }
        public Lucio[] lucio { get; set; }
        public Mei[] mei { get; set; }
        public Mercy[] mercy { get; set; }
        public Moira[] moira { get; set; }
        public Orisa[] orisa { get; set; }
        public Pharah[] pharah { get; set; }
        public Ramattra[] ramattra { get; set; }
        public Reaper[] reaper { get; set; }
        public Reinhardt[] reinhardt { get; set; }
        public Roadhog[] roadhog { get; set; }
        public Sigma[] sigma { get; set; }
        public Sojourn[] sojourn { get; set; }
        public Soldier76[] soldier76 { get; set; }
        public Sombra[] sombra { get; set; }
        public Symmetra[] symmetra { get; set; }
        public Torbjorn[] torbjorn { get; set; }
        public Tracer[] tracer { get; set; }
        public Widowmaker[] widowmaker { get; set; }
        public Winston[] winston { get; set; }
        public WreckingBall[] wreckingball { get; set; }
        public Zarya[] zarya { get; set; }
        public Zenyatta[] zenyatta { get; set; }
    }

    public class AllHeroes
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat[] stats { get; set; }
    }

    public class Stat
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Ana
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat1[] stats { get; set; }
    }

    public class Stat1
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Ashe
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat2[] stats { get; set; }
    }

    public class Stat2
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Baptiste
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat3[] stats { get; set; }
    }

    public class Stat3
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Bastion
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat4[] stats { get; set; }
    }

    public class Stat4
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Brigitte
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat5[] stats { get; set; }
    }

    public class Stat5
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Cassidy
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat6[] stats { get; set; }
    }

    public class Stat6
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Dva
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat7[] stats { get; set; }
    }

    public class Stat7
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Doomfist
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat8[] stats { get; set; }
    }

    public class Stat8
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Echo
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat9[] stats { get; set; }
    }

    public class Stat9
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Genji
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat10[] stats { get; set; }
    }

    public class Stat10
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Hanzo
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat11[] stats { get; set; }
    }

    public class Stat11
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class JunkerQueen
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat12[] stats { get; set; }
    }

    public class Stat12
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Junkrat
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat13[] stats { get; set; }
    }

    public class Stat13
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Kiriko
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat14[] stats { get; set; }
    }

    public class Stat14
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Lucio
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat15[] stats { get; set; }
    }

    public class Stat15
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Mei
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat16[] stats { get; set; }
    }

    public class Stat16
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Mercy
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat17[] stats { get; set; }
    }

    public class Stat17
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Moira
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat18[] stats { get; set; }
    }

    public class Stat18
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Orisa
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat19[] stats { get; set; }
    }

    public class Stat19
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Pharah
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat20[] stats { get; set; }
    }

    public class Stat20
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Ramattra
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat21[] stats { get; set; }
    }

    public class Stat21
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Reaper
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat22[] stats { get; set; }
    }

    public class Stat22
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Reinhardt
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat23[] stats { get; set; }
    }

    public class Stat23
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Roadhog
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat24[] stats { get; set; }
    }

    public class Stat24
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Sigma
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat25[] stats { get; set; }
    }

    public class Stat25
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Sojourn
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat26[] stats { get; set; }
    }

    public class Stat26
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Soldier76
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat27[] stats { get; set; }
    }

    public class Stat27
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Sombra
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat28[] stats { get; set; }
    }

    public class Stat28
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Symmetra
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat29[] stats { get; set; }
    }

    public class Stat29
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Torbjorn
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat30[] stats { get; set; }
    }

    public class Stat30
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Tracer
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat31[] stats { get; set; }
    }

    public class Stat31
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Widowmaker
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat32[] stats { get; set; }
    }

    public class Stat32
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Winston
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat33[] stats { get; set; }
    }

    public class Stat33
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class WreckingBall
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat34[] stats { get; set; }
    }

    public class Stat34
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Zarya
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat35[] stats { get; set; }
    }

    public class Stat35
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Zenyatta
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat36[] stats { get; set; }
    }

    public class Stat36
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Competitive
    {
        public Heroes_Comparisons1 heroes_comparisons { get; set; }
        public Career_Stats1 career_stats { get; set; }
    }

    public class Heroes_Comparisons1
    {
        public Time_Played1 time_played { get; set; }
        public Games_Won1 games_won { get; set; }
        public Weapon_Accuracy1 weapon_accuracy { get; set; }
        public Win_Percentage win_percentage { get; set; }
        public Eliminations_Per_Life1 eliminations_per_life { get; set; }
        public Critical_Hit_Accuracy1 critical_hit_accuracy { get; set; }
        public Multikill_Best1 multikill_best { get; set; }
        public Objective_Kills1 objective_kills { get; set; }
    }

    public class Time_Played1
    {
        public string label { get; set; }
        public Value7[] values { get; set; }
    }

    public class Value7
    {
        public string hero { get; set; }
        public int value { get; set; }
    }

    public class Games_Won1
    {
        public string label { get; set; }
        public Value8[] values { get; set; }
    }

    public class Value8
    {
        public string hero { get; set; }
        public int value { get; set; }
    }

    public class Weapon_Accuracy1
    {
        public string label { get; set; }
        public Value9[] values { get; set; }
    }

    public class Value9
    {
        public string hero { get; set; }
        public int value { get; set; }
    }

    public class Win_Percentage
    {
        public string label { get; set; }
        public Value10[] values { get; set; }
    }

    public class Value10
    {
        public string hero { get; set; }
        public int value { get; set; }
    }

    public class Eliminations_Per_Life1
    {
        public string label { get; set; }
        public Value11[] values { get; set; }
    }

    public class Value11
    {
        public string hero { get; set; }
        public float value { get; set; }
    }

    public class Critical_Hit_Accuracy1
    {
        public string label { get; set; }
        public Value12[] values { get; set; }
    }

    public class Value12
    {
        public string hero { get; set; }
        public int value { get; set; }
    }

    public class Multikill_Best1
    {
        public string label { get; set; }
        public Value13[] values { get; set; }
    }

    public class Value13
    {
        public string hero { get; set; }
        public int value { get; set; }
    }

    public class Objective_Kills1
    {
        public string label { get; set; }
        public Value14[] values { get; set; }
    }

    public class Value14
    {
        public string hero { get; set; }
        public int value { get; set; }
    }

    public class Career_Stats1
    {
        public AllHeroes1[] allheroes { get; set; }
        public Ana1[] ana { get; set; }
        public Ashe1[] ashe { get; set; }
        public Bastion1[] bastion { get; set; }
        public Cassidy1[] cassidy { get; set; }
        public Dva1[] dva { get; set; }
        public Doomfist1[] doomfist { get; set; }
        public Echo1[] echo { get; set; }
        public Hanzo1[] hanzo { get; set; }
        public JunkerQueen1[] junkerqueen { get; set; }
        public Junkrat1[] junkrat { get; set; }
        public Kiriko1[] kiriko { get; set; }
        public Lucio1[] lucio { get; set; }
        public Mercy1[] mercy { get; set; }
        public Moira1[] moira { get; set; }
        public Orisa1[] orisa { get; set; }
        public Ramattra1[] ramattra { get; set; }
        public Reaper1[] reaper { get; set; }
        public Reinhardt1[] reinhardt { get; set; }
        public Roadhog1[] roadhog { get; set; }
        public Sigma1[] sigma { get; set; }
        public Sojourn1[] sojourn { get; set; }
        public Soldier761[] soldier76 { get; set; }
        public Symmetra1[] symmetra { get; set; }
        public Torbjorn1[] torbjorn { get; set; }
        public Tracer1[] tracer { get; set; }
        public Widowmaker1[] widowmaker { get; set; }
        public Winston1[] winston { get; set; }
        public WreckingBall1[] wreckingball { get; set; }
        public Zarya1[] zarya { get; set; }
        public Zenyatta1[] zenyatta { get; set; }
        public object baptiste { get; set; }
        public object brigitte { get; set; }
        public object genji { get; set; }
        public object mei { get; set; }
        public object pharah { get; set; }
        public object sombra { get; set; }
    }

    public class AllHeroes1
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat37[] stats { get; set; }
    }

    public class Stat37
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Ana1
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat38[] stats { get; set; }
    }

    public class Stat38
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Ashe1
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat39[] stats { get; set; }
    }

    public class Stat39
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Bastion1
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat40[] stats { get; set; }
    }

    public class Stat40
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Cassidy1
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat41[] stats { get; set; }
    }

    public class Stat41
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Dva1
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat42[] stats { get; set; }
    }

    public class Stat42
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Doomfist1
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat43[] stats { get; set; }
    }

    public class Stat43
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Echo1
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat44[] stats { get; set; }
    }

    public class Stat44
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Hanzo1
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat45[] stats { get; set; }
    }

    public class Stat45
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class JunkerQueen1
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat46[] stats { get; set; }
    }

    public class Stat46
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Junkrat1
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat47[] stats { get; set; }
    }

    public class Stat47
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Kiriko1
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat48[] stats { get; set; }
    }

    public class Stat48
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Lucio1
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat49[] stats { get; set; }
    }

    public class Stat49
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Mercy1
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat50[] stats { get; set; }
    }

    public class Stat50
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Moira1
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat51[] stats { get; set; }
    }

    public class Stat51
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Orisa1
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat52[] stats { get; set; }
    }

    public class Stat52
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Ramattra1
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat53[] stats { get; set; }
    }

    public class Stat53
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Reaper1
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat54[] stats { get; set; }
    }

    public class Stat54
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Reinhardt1
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat55[] stats { get; set; }
    }

    public class Stat55
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Roadhog1
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat56[] stats { get; set; }
    }

    public class Stat56
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Sigma1
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat57[] stats { get; set; }
    }

    public class Stat57
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Sojourn1
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat58[] stats { get; set; }
    }

    public class Stat58
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Soldier761
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat59[] stats { get; set; }
    }

    public class Stat59
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Symmetra1
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat60[] stats { get; set; }
    }

    public class Stat60
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Torbjorn1
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat61[] stats { get; set; }
    }

    public class Stat61
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Tracer1
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat62[] stats { get; set; }
    }

    public class Stat62
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Widowmaker1
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat63[] stats { get; set; }
    }

    public class Stat63
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Winston1
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat64[] stats { get; set; }
    }

    public class Stat64
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class WreckingBall1
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat65[] stats { get; set; }
    }

    public class Stat65
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Zarya1
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat66[] stats { get; set; }
    }

    public class Stat66
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

    public class Zenyatta1
    {
        public string category { get; set; }
        public string label { get; set; }
        public Stat67[] stats { get; set; }
    }

    public class Stat67
    {
        public string key { get; set; }
        public string label { get; set; }
        public float value { get; set; }
    }

}
