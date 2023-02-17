using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAPITests
{

    public class OverfastResponseSummary
    {
        public General general { get; set; }
        public Roles roles { get; set; }
        public Heroes heroes { get; set; }
    }

    public class General
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total total { get; set; }
        public Average average { get; set; }
    }

    public class Total
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Roles
    {
        public Tank tank { get; set; }
        public Damage damage { get; set; }
        public Support support { get; set; }
    }

    public class Tank
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total1 total { get; set; }
        public Average1 average { get; set; }
    }

    public class Total1
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average1
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Damage
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total2 total { get; set; }
        public Average2 average { get; set; }
    }

    public class Total2
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average2
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Support
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total3 total { get; set; }
        public Average3 average { get; set; }
    }

    public class Total3
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average3
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Heroes
    {
        public Ana ana { get; set; }
        public Ashe ashe { get; set; }
        public Baptiste baptiste { get; set; }
        public Bastion bastion { get; set; }
        public Brigitte brigitte { get; set; }
        public Cassidy cassidy { get; set; }
        public Dva dva { get; set; }
        public Doomfist doomfist { get; set; }
        public Echo echo { get; set; }
        public Genji genji { get; set; }
        public Hanzo hanzo { get; set; }
        public JunkerQueen junkerqueen { get; set; }
        public Junkrat junkrat { get; set; }
        public Kiriko kiriko { get; set; }
        public Lucio lucio { get; set; }
        public Mei mei { get; set; }
        public Mercy mercy { get; set; }
        public Moira moira { get; set; }
        public Orisa orisa { get; set; }
        public Pharah pharah { get; set; }
        public Ramattra ramattra { get; set; }
        public Reaper reaper { get; set; }
        public Reinhardt reinhardt { get; set; }
        public Roadhog roadhog { get; set; }
        public Sigma sigma { get; set; }
        public Soldier76 soldier76 { get; set; }
        public Sojourn sojourn { get; set; }
        public Sombra sombra { get; set; }
        public Symmetra symmetra { get; set; }
        public Torbjorn torbjorn { get; set; }
        public Tracer tracer { get; set; }
        public Widowmaker widowmaker { get; set; }
        public Winston winston { get; set; }
        public WreckingBall wreckingball { get; set; }
        public Zarya zarya { get; set; }
        public Zenyatta zenyatta { get; set; }
    }

    public class Ana
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total4 total { get; set; }
        public Average4 average { get; set; }
    }

    public class Total4
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average4
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Ashe
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total5 total { get; set; }
        public Average5 average { get; set; }
    }

    public class Total5
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average5
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Baptiste
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total6 total { get; set; }
        public Average6 average { get; set; }
    }

    public class Total6
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average6
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Bastion
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total7 total { get; set; }
        public Average7 average { get; set; }
    }

    public class Total7
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average7
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Brigitte
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total8 total { get; set; }
        public Average8 average { get; set; }
    }

    public class Total8
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average8
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Cassidy
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total9 total { get; set; }
        public Average9 average { get; set; }
    }

    public class Total9
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average9
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Dva
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total10 total { get; set; }
        public Average10 average { get; set; }
    }

    public class Total10
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average10
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Doomfist
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total11 total { get; set; }
        public Average11 average { get; set; }
    }

    public class Total11
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average11
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Echo
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total12 total { get; set; }
        public Average12 average { get; set; }
    }

    public class Total12
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average12
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Genji
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total13 total { get; set; }
        public Average13 average { get; set; }
    }

    public class Total13
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average13
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Hanzo
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total14 total { get; set; }
        public Average14 average { get; set; }
    }

    public class Total14
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average14
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class JunkerQueen
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total15 total { get; set; }
        public Average15 average { get; set; }
    }

    public class Total15
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average15
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Junkrat
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total16 total { get; set; }
        public Average16 average { get; set; }
    }

    public class Total16
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average16
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Kiriko
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total17 total { get; set; }
        public Average17 average { get; set; }
    }

    public class Total17
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average17
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Lucio
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total18 total { get; set; }
        public Average18 average { get; set; }
    }

    public class Total18
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average18
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Mei
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total19 total { get; set; }
        public Average19 average { get; set; }
    }

    public class Total19
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average19
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Mercy
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total20 total { get; set; }
        public Average20 average { get; set; }
    }

    public class Total20
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average20
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Moira
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total21 total { get; set; }
        public Average21 average { get; set; }
    }

    public class Total21
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average21
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Orisa
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total22 total { get; set; }
        public Average22 average { get; set; }
    }

    public class Total22
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average22
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Pharah
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total23 total { get; set; }
        public Average23 average { get; set; }
    }

    public class Total23
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average23
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Ramattra
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total24 total { get; set; }
        public Average24 average { get; set; }
    }

    public class Total24
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average24
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Reaper
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total25 total { get; set; }
        public Average25 average { get; set; }
    }

    public class Total25
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average25
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Reinhardt
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total26 total { get; set; }
        public Average26 average { get; set; }
    }

    public class Total26
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average26
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Roadhog
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total27 total { get; set; }
        public Average27 average { get; set; }
    }

    public class Total27
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average27
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Sigma
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total28 total { get; set; }
        public Average28 average { get; set; }
    }

    public class Total28
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average28
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Soldier76
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total29 total { get; set; }
        public Average29 average { get; set; }
    }

    public class Total29
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average29
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Sojourn
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total30 total { get; set; }
        public Average30 average { get; set; }
    }

    public class Total30
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average30
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Sombra
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total31 total { get; set; }
        public Average31 average { get; set; }
    }

    public class Total31
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average31
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Symmetra
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total32 total { get; set; }
        public Average32 average { get; set; }
    }

    public class Total32
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average32
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Torbjorn
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total33 total { get; set; }
        public Average33 average { get; set; }
    }

    public class Total33
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average33
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Tracer
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total34 total { get; set; }
        public Average34 average { get; set; }
    }

    public class Total34
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average34
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Widowmaker
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total35 total { get; set; }
        public Average35 average { get; set; }
    }

    public class Total35
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average35
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Winston
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total36 total { get; set; }
        public Average36 average { get; set; }
    }

    public class Total36
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average36
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class WreckingBall
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total37 total { get; set; }
        public Average37 average { get; set; }
    }

    public class Total37
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average37
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Zarya
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total38 total { get; set; }
        public Average38 average { get; set; }
    }

    public class Total38
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average38
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

    public class Zenyatta
    {
        public int games_played { get; set; }
        public int time_played { get; set; }
        public float winrate { get; set; }
        public float kda { get; set; }
        public Total39 total { get; set; }
        public Average39 average { get; set; }
    }

    public class Total39
    {
        public int eliminations { get; set; }
        public int assists { get; set; }
        public int deaths { get; set; }
        public int damage { get; set; }
        public int healing { get; set; }
    }

    public class Average39
    {
        public float eliminations { get; set; }
        public float assists { get; set; }
        public float deaths { get; set; }
        public float damage { get; set; }
        public float healing { get; set; }
    }

}
