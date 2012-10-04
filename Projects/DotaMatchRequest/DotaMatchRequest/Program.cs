using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;


using SteamKit2.GC.Dota.Internal; // for CMsgDOTAMatch


namespace DotaMatchRequest
{
    class Program
    {
        static void Main( string[] args )
        {
            if ( args.Length < 3 )
            {
                PrintUsage();
                return;
            }

            string username = args[ 0 ];
            string password = args[ 1 ];

            uint matchId;
            if ( !uint.TryParse( args[ 2 ], out matchId ) )
            {
                Console.WriteLine( "Invalid Match ID!" );
                return;
            }

            DotaClient client = new DotaClient( username, password, matchId );

            // connect
            client.Connect();

            // wait for results of the match request
            client.Wait();

            // print off what steam gave us
            PrintMatchDetails( client.Match );
        }


        static void PrintMatchDetails( CMsgDOTAMatch match )
        {
            if ( match == null )
            {
                Console.WriteLine( "No match details to display" );
                return;
            }
			
			Console.Write('{');
			Console.Write("'match_id':{0},'start_time':{1}, 'duration':{2},\n", match.match_id, match.startTime, match.duration);
			
			Console.Write("'players':[\n");
			int i = 0;
			foreach (CMsgDOTAMatch.Player p in match.players) {
				Console.Write('{');
				
				Console.Write("'previous_rank':{0},",p.previous_rank);
				Console.Write("'rank_change':{0},",p.rank_change);
				Console.Write("'rank_change':{0},",p.rank_change);
				Console.Write("'rank_uncertainty_change':{0},",p.rank_uncertainty_change);
				Console.Write("'scaled_assists':{0},",p.scaled_assists);
				Console.Write("'scaled_deaths':{0},",p.scaled_deaths);
				Console.Write("'scaled_kills':{0},",p.scaled_kills);
				Console.Write("'scaled_metric':{0},",p.scaled_metric);
				Console.Write("'search_rank':{0},",p.search_rank);
				Console.Write("'search_rank_uncertainty':{0},",p.search_rank_uncertainty);
				Console.Write("'support_ability_value':{0},",p.support_ability_value);
				Console.Write("'support_gold':{0},",p.support_gold);
				Console.Write("'time_last_seen':{0},",p.time_last_seen);
				Console.Write("'tower_damage':{0},",p.tower_damage);
				Console.Write("'xp_per_min':{0},",p.XP_per_min);
				Console.Write("'account_id':{0},",p.account_id);
				Console.Write("'assists':{0},",p.assists);
				Console.Write("'claimed_denies':{0},",p.claimed_denies);
				Console.Write("'calimed_farm_gold':{0},",p.claimed_farm_gold);
				Console.Write("'deaths':{0},",p.deaths);
				Console.Write("'denies':{0},",p.denies);
				Console.Write("'expected_team_contribution':{0},",p.expected_team_contribution);
				String s = String.Format("'feeding_detected':{0},",p.feeding_detected);
				Console.Write(s.ToLower());
				Console.Write("'gold':{0},",p.gold);
				Console.Write("'gold_per_min':{0},",p.gold_per_min);
				Console.Write("'hero_damage':{0},",p.hero_damage);
				Console.Write("'hero_healing':{0},",p.hero_healing);
				Console.Write("'hero_id':{0},",p.hero_id);
				Console.Write("'hero_play_count':{0},",p.hero_play_count);
				Console.Write("'item_0':{0},",p.item_0);
				Console.Write("'item_1':{0},",p.item_1);
				Console.Write("'item_2':{0},",p.item_2);
				Console.Write("'item_3':{0},",p.item_3);
				Console.Write("'item_4':{0},",p.item_4);
				Console.Write("'item_5':{0},",p.item_5);
				Console.Write("'kills':{0},",p.kills);
				Console.Write("'last_hits':{0},",p.last_hits);
				Console.Write("'leaver_status':{0},",p.leaver_status);
				Console.Write("'misses':{0},",p.misses);
				Console.Write("'party_id':{0},",p.party_id);
				Console.Write("'player_name':'{0}',",p.player_name);
				Console.Write("'player_slot':{0}",p.player_slot);
				
				Console.Write('}');
				i++;
				if (i != match.players.Count) {
					Console.Write(",");
				}
				Console.WriteLine("");
				
			}
			Console.Write("]}");
		}

        static void PrintUsage()
        {
            Console.WriteLine( "Usage:" );
            Console.WriteLine( "DotaMatchRequest <username> <password> <matchid>" );
        }
    }
}
