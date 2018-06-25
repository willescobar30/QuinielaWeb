using System;
using System.Collections.Generic;
using System.Text;

namespace QW.ExternalApi.Models
{
    public class Stadium
    {
        public int id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
        public string image { get; set; }
    }

    public class Tvchannel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public string country { get; set; }
        public string iso2 { get; set; }
        public List<string> lang { get; set; }
    }

    public class Team
    {
        public int id { get; set; }
        public string name { get; set; }
        public string fifaCode { get; set; }
        public string iso2 { get; set; }
        public string flag { get; set; }
        public string emoji { get; set; }
        public string emojiString { get; set; }
    }

    public class Match
    {
        public int name { get; set; }
        public string type { get; set; }
        public int home_team { get; set; }
        public int away_team { get; set; }
        public int? home_result { get; set; }
        public int? away_result { get; set; }
        public DateTime date { get; set; }
        public int stadium { get; set; }
        public List<int> channels { get; set; }
        public bool finished { get; set; }
        public int matchday { get; set; }
    }

    public class A
    {
        public string name { get; set; }
        public object winner { get; set; }
        public object runnerup { get; set; }
        public List<Match> matches { get; set; }
    }

    public class Match2
    {
        public int name { get; set; }
        public string type { get; set; }
        public int home_team { get; set; }
        public int away_team { get; set; }
        public int? home_result { get; set; }
        public int? away_result { get; set; }
        public DateTime date { get; set; }
        public int stadium { get; set; }
        public List<int> channels { get; set; }
        public bool finished { get; set; }
        public int matchday { get; set; }
    }

    public class B
    {
        public string name { get; set; }
        public object winner { get; set; }
        public object runnerup { get; set; }
        public List<Match2> matches { get; set; }
    }

    public class Match3
    {
        public int name { get; set; }
        public string type { get; set; }
        public int home_team { get; set; }
        public int away_team { get; set; }
        public int? home_result { get; set; }
        public int? away_result { get; set; }
        public DateTime date { get; set; }
        public int stadium { get; set; }
        public List<int> channels { get; set; }
        public bool finished { get; set; }
        public int matchday { get; set; }
    }

    public class C
    {
        public string name { get; set; }
        public object winner { get; set; }
        public object runnerup { get; set; }
        public List<Match3> matches { get; set; }
    }

    public class Match4
    {
        public int name { get; set; }
        public string type { get; set; }
        public int home_team { get; set; }
        public int away_team { get; set; }
        public int? home_result { get; set; }
        public int? away_result { get; set; }
        public DateTime date { get; set; }
        public int stadium { get; set; }
        public List<int> channels { get; set; }
        public bool finished { get; set; }
        public int matchday { get; set; }
    }

    public class D
    {
        public string name { get; set; }
        public object winner { get; set; }
        public object runnerup { get; set; }
        public List<Match4> matches { get; set; }
    }

    public class Match5
    {
        public int name { get; set; }
        public string type { get; set; }
        public int home_team { get; set; }
        public int away_team { get; set; }
        public int? home_result { get; set; }
        public int? away_result { get; set; }
        public DateTime date { get; set; }
        public int stadium { get; set; }
        public List<int> channels { get; set; }
        public bool finished { get; set; }
        public int matchday { get; set; }
    }

    public class E
    {
        public string name { get; set; }
        public object winner { get; set; }
        public object runnerup { get; set; }
        public List<Match5> matches { get; set; }
    }

    public class Match6
    {
        public int name { get; set; }
        public string type { get; set; }
        public int home_team { get; set; }
        public int away_team { get; set; }
        public int? home_result { get; set; }
        public int? away_result { get; set; }
        public DateTime date { get; set; }
        public int stadium { get; set; }
        public List<int> channels { get; set; }
        public bool finished { get; set; }
        public int matchday { get; set; }
    }

    public class F
    {
        public string name { get; set; }
        public object winner { get; set; }
        public object runnerup { get; set; }
        public List<Match6> matches { get; set; }
    }

    public class Match7
    {
        public int name { get; set; }
        public string type { get; set; }
        public int home_team { get; set; }
        public int away_team { get; set; }
        public int? home_result { get; set; }
        public int? away_result { get; set; }
        public DateTime date { get; set; }
        public int stadium { get; set; }
        public List<int> channels { get; set; }
        public bool finished { get; set; }
        public int matchday { get; set; }
    }

    public class G
    {
        public string name { get; set; }
        public object winner { get; set; }
        public object runnerup { get; set; }
        public List<Match7> matches { get; set; }
    }

    public class Match8
    {
        public int name { get; set; }
        public string type { get; set; }
        public int home_team { get; set; }
        public int away_team { get; set; }
        public int? home_result { get; set; }
        public int? away_result { get; set; }
        public DateTime date { get; set; }
        public int stadium { get; set; }
        public List<int> channels { get; set; }
        public bool finished { get; set; }
        public int matchday { get; set; }
    }

    public class H
    {
        public string name { get; set; }
        public object winner { get; set; }
        public object runnerup { get; set; }
        public List<Match8> matches { get; set; }
    }

    public class Groups
    {
        public A a { get; set; }
        public B b { get; set; }
        public C c { get; set; }
        public D d { get; set; }
        public E e { get; set; }
        public F f { get; set; }
        public G g { get; set; }
        public H h { get; set; }
    }

    public class Match9
    {
        public int name { get; set; }
        public string type { get; set; }
        public string home_team { get; set; }
        public string away_team { get; set; }
        public object home_result { get; set; }
        public object away_result { get; set; }
        public object home_penalty { get; set; }
        public object away_penalty { get; set; }
        public object winner { get; set; }
        public DateTime date { get; set; }
        public int stadium { get; set; }
        public List<int> channels { get; set; }
        public bool finished { get; set; }
        public int matchday { get; set; }
    }

    public class Round16
    {
        public string name { get; set; }
        public List<Match9> matches { get; set; }
    }

    public class Match10
    {
        public int name { get; set; }
        public string type { get; set; }
        public int home_team { get; set; }
        public int away_team { get; set; }
        public object home_result { get; set; }
        public object away_result { get; set; }
        public object home_penalty { get; set; }
        public object away_penalty { get; set; }
        public object winner { get; set; }
        public DateTime date { get; set; }
        public int stadium { get; set; }
        public List<int> channels { get; set; }
        public bool finished { get; set; }
        public int matchday { get; set; }
    }

    public class Round8
    {
        public string name { get; set; }
        public List<Match10> matches { get; set; }
    }

    public class Match11
    {
        public int name { get; set; }
        public string type { get; set; }
        public int home_team { get; set; }
        public int away_team { get; set; }
        public object home_result { get; set; }
        public object away_result { get; set; }
        public object home_penalty { get; set; }
        public object away_penalty { get; set; }
        public object winner { get; set; }
        public DateTime date { get; set; }
        public int stadium { get; set; }
        public List<int> channels { get; set; }
        public bool finished { get; set; }
        public int matchday { get; set; }
    }

    public class Round4
    {
        public string name { get; set; }
        public List<Match11> matches { get; set; }
    }

    public class Match12
    {
        public int name { get; set; }
        public string type { get; set; }
        public int home_team { get; set; }
        public int away_team { get; set; }
        public object home_result { get; set; }
        public object away_result { get; set; }
        public object home_penalty { get; set; }
        public object away_penalty { get; set; }
        public object winner { get; set; }
        public DateTime date { get; set; }
        public int stadium { get; set; }
        public List<int> channels { get; set; }
        public bool finished { get; set; }
        public int matchday { get; set; }
    }

    public class Round2Loser
    {
        public string name { get; set; }
        public List<Match12> matches { get; set; }
    }

    public class Match13
    {
        public int name { get; set; }
        public string type { get; set; }
        public int home_team { get; set; }
        public int away_team { get; set; }
        public object home_result { get; set; }
        public object away_result { get; set; }
        public object home_penalty { get; set; }
        public object away_penalty { get; set; }
        public object winner { get; set; }
        public DateTime date { get; set; }
        public int stadium { get; set; }
        public List<int> channels { get; set; }
        public bool finished { get; set; }
        public int matchday { get; set; }
    }

    public class Round2
    {
        public string name { get; set; }
        public List<Match13> matches { get; set; }
    }

    public class Knockout
    {
        public Round16 round_16 { get; set; }
        public Round8 round_8 { get; set; }
        public Round4 round_4 { get; set; }
        public Round2Loser round_2_loser { get; set; }
        public Round2 round_2 { get; set; }
    }

    public class RootObject
    {
        public List<Stadium> stadiums { get; set; }
        public List<Tvchannel> tvchannels { get; set; }
        public List<Team> teams { get; set; }
        public Groups groups { get; set; }
        public Knockout knockout { get; set; }
    }
}
