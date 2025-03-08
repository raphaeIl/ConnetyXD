using Microsoft.AspNetCore.Mvc;
using Serilog;
using System.Text;

namespace ConnetyXD.GameServer.Controllers
{
    [ApiController]
    [Route("/")]
    public class SDKController : ControllerBase
    {
        [Route("member/api/v1/game/auth/signin/refresh/token")]
        public IResult PostToken()
        {
            Log.Information("PostToken");
            return Results.Text(@"
{
    ""resultCode"": ""SUCCESS"",
    ""resultData"": {
        ""accessToken"": ""eyJhbGciOiJIUzI1NiJ9.eyJpbUlkIjoiV0ZFOUFCVjREWTUzUjlGNlE5QTciLCJwaklkIjoiMTAwOCIsInR5cGUiOiJTRVNTSU9OIiwic3ViIjoiNWZkNWE5MTctY2M2MS00Y2FiLWFiMDAtMWYyNTIzZTNjMzI5IiwiaXNzIjoiaHliZWltLXBsYXRmb3JtLXAiLCJhdWQiOlsiaHliZWltLWdhbWUtcCJdLCJpYXQiOjE3NDEyMzYyOTMsImV4cCI6MTc0MzgyODI5M30.MWI71W7wORvrgSneqJ85mlyRHMnCRJw_pmUMFhMLpog"",
        ""countryCode"": ""US"",
        ""imId"": ""WFE9ABV4DY53R9F6Q9A7""
    },
    ""resultMessage"": ""success""
}
", "application/json");
        }

        [Route("member/api/v1/game/auth/check/available")]
        public IResult GetCheckAvailable()
        {
            Log.Information("GetCheckAvailable");

            return Results.Text(@"
{
    ""resultCode"": ""SUCCESS"",
    ""resultData"": {
        ""adNightPush"": true,
        ""adPush"": true,
        ""advertising"": true,
        ""imId"": ""WFE9ABV4DY53R9F6Q9A7"",
        ""loginVerifyToken"": ""eyJhbGciOiJIUzI1NiJ9.eyJpbUlkIjoiV0ZFOUFCVjREWTUzUjlGNlE5QTciLCJwaklkIjoiMTAwOCIsInR5cGUiOiJMT0dJTl9WRVJJRlkiLCJzdWIiOiJhNzVmMTY0OS0yZjg1LTQ2YWEtYjMxYy1hODYzODJjNzFhODYiLCJpc3MiOiJoeWJlaW0tcGxhdGZvcm0tcCIsImF1ZCI6WyJoeWJlaW0tc2VydmVyLXAiXSwiaWF0IjoxNzQxMjM2Mjk0LCJleHAiOjE3NDEyMzk4OTR9.2CVKU6RtYxJ3kTFb4CbwDov0H_48PfJc7OYnREVGUW0""
    },
    ""resultMessage"": ""success""
}
", "application/json");
        }


//        [Route("oz/auth/access")]
//        public IResult PostAuthAccess()
//        {
//            return Results.Text(@"
//{
//    ""error"": {
//        ""message"": ""success""
//    },
//    ""login_info"": {
//        ""im_id"": ""PFFXZ28WG7LP9DEKT7Q4"",
//        ""session_key"": ""308ab28f-d5b0-4cb8-a0a6-00f16c425892"",
//        ""session_expire_time"": 1741319506,
//        ""server_time"": 1741317706,
//        ""server_daily_reset_time"": 1741374000,
//        ""lobby"": {
//            ""place_char_ids"": [
//                ""Char_001_S01_B""
//            ]
//        },
//        ""reader"": {
//            ""level"": 1,
//            ""login_time"": 1741317706,
//            ""create_time"": 1741236940,
//            ""profiles"": {
//                ""1"": {
//                    ""type"": 1,
//                    ""value"": ""PFFXZ28WG7LP9DEKT7Q4""
//                },
//                ""2"": {
//                    ""type"": 2,
//                    ""value"": ""neko"",
//                    ""update_at"": 1741237348
//                },
//                ""3"": {
//                    ""type"": 3,
//                    ""value"": ""10"",
//                    ""update_at"": 1741288386
//                },
//                ""4"": {
//                    ""type"": 4,
//                    ""value"": ""Title_Default""
//                },
//                ""7"": {
//                    ""type"": 7,
//                    ""value"": ""Char_001_S01_B""
//                },
//                ""8"": {
//                    ""type"": 8,
//                    ""value"": ""47f77b59-40bf-4d51-b891-74c1ac323e44""
//                }
//            }
//        },
//        ""option"": {
//            ""options"": ""{\""ConfigDetails\"":[{\""CategoryType\"":0,\""DetailsType\"":0,\""Value\"":0,\""Volume\"":1.0,\""Disable\"":false},{\""CategoryType\"":0,\""DetailsType\"":1,\""Value\"":2,\""Volume\"":1.0,\""Disable\"":false},{\""CategoryType\"":0,\""DetailsType\"":2,\""Value\"":0,\""Volume\"":1.0,\""Disable\"":false},{\""CategoryType\"":0,\""DetailsType\"":3,\""Value\"":0,\""Volume\"":1.0,\""Disable\"":false},{\""CategoryType\"":0,\""DetailsType\"":4,\""Value\"":0,\""Volume\"":1.0,\""Disable\"":false},{\""CategoryType\"":1,\""DetailsType\"":5,\""Value\"":0,\""Volume\"":1.0,\""Disable\"":false},{\""CategoryType\"":1,\""DetailsType\"":6,\""Value\"":2,\""Volume\"":1.0,\""Disable\"":false},{\""CategoryType\"":2,\""DetailsType\"":7,\""Value\"":100,\""Volume\"":1.0,\""Disable\"":false},{\""CategoryType\"":2,\""DetailsType\"":8,\""Value\"":50,\""Volume\"":1.0,\""Disable\"":false},{\""CategoryType\"":2,\""DetailsType\"":9,\""Value\"":70,\""Volume\"":1.0,\""Disable\"":false},{\""CategoryType\"":2,\""DetailsType\"":10,\""Value\"":90,\""Volume\"":1.0,\""Disable\"":false},{\""CategoryType\"":3,\""DetailsType\"":11,\""Value\"":1,\""Volume\"":1.0,\""Disable\"":false},{\""CategoryType\"":4,\""DetailsType\"":12,\""Value\"":0,\""Volume\"":1.0,\""Disable\"":false},{\""CategoryType\"":4,\""DetailsType\"":13,\""Value\"":0,\""Volume\"":1.0,\""Disable\"":false},{\""CategoryType\"":4,\""DetailsType\"":14,\""Value\"":1,\""Volume\"":1.0,\""Disable\"":false},{\""CategoryType\"":4,\""DetailsType\"":15,\""Value\"":1,\""Volume\"":1.0,\""Disable\"":false},{\""CategoryType\"":4,\""DetailsType\"":16,\""Value\"":1,\""Volume\"":1.0,\""Disable\"":false},{\""CategoryType\"":1,\""DetailsType\"":17,\""Value\"":1,\""Volume\"":1.0,\""Disable\"":false}]}""
//        },
//        ""kingdom"": {
//            ""schedule_ticket_cnt"": 2,
//            ""schedule_ticket_reset_time"": 1741258800,
//            ""system_invite_reset_time"": 1741258800,
//            ""invite_chars"": {
//                ""Char_001_S01_B"": {
//                    ""id"": ""Char_001_S01_B"",
//                    ""enable_interaction"": true
//                },
//                ""Char_010_S01_B"": {
//                    ""id"": ""Char_010_S01_B"",
//                    ""enable_interaction"": true
//                },
//                ""Char_078_S01_R"": {
//                    ""id"": ""Char_078_S01_R"",
//                    ""enable_interaction"": true
//                },
//                ""Char_084_S01_G"": {
//                    ""id"": ""Char_084_S01_G"",
//                    ""enable_interaction"": true
//                },
//                ""Char_088_S01_R"": {
//                    ""id"": ""Char_088_S01_R"",
//                    ""enable_interaction"": true
//                },
//                ""Char_105_S01_B"": {
//                    ""id"": ""Char_105_S01_B"",
//                    ""enable_interaction"": true
//                }
//            }
//        },
//        ""identifier"": {
//            ""create_time"": 1741236940
//        },
//        ""chars"": {
//            ""Char_001_S01_B"": {
//                ""id"": ""Char_001_S01_B"",
//                ""food"": {
//                    ""satiety_update_time"": 1741236940
//                },
//                ""level"": 1,
//                ""grade"": 1,
//                ""skills"": {
//                    ""Skill_C_001_01_B_ActiveSkill"": 1,
//                    ""Skill_C_001_01_B_AtkE"": 1,
//                    ""Skill_C_001_01_B_AtkM"": 1,
//                    ""Skill_C_001_01_B_LinkSkill"": 1,
//                    ""Skill_C_001_01_B_Passive"": 1
//                },
//                ""friendship_level"": 1,
//                ""create_at"": 1741236940
//            },
//            ""Char_002_S01_R"": {
//                ""id"": ""Char_002_S01_R"",
//                ""food"": {
//                    ""satiety_update_time"": 1741236940
//                },
//                ""level"": 1,
//                ""grade"": 2,
//                ""skills"": {
//                    ""Skill_C_002_01_R_ActiveSkill"": 1,
//                    ""Skill_C_002_01_R_AtkE"": 1,
//                    ""Skill_C_002_01_R_AtkM"": 1,
//                    ""Skill_C_002_01_R_LinkSkill"": 1,
//                    ""Skill_C_002_01_R_Passive"": 1
//                },
//                ""friendship_level"": 1,
//                ""create_at"": 1741236940
//            },
//            ""Char_003_S01_B"": {
//                ""id"": ""Char_003_S01_B"",
//                ""food"": {
//                    ""satiety_update_time"": 1741236940
//                },
//                ""level"": 1,
//                ""grade"": 2,
//                ""skills"": {
//                    ""Skill_C_003_01_B_ActiveSkill"": 1,
//                    ""Skill_C_003_01_B_AtkE"": 1,
//                    ""Skill_C_003_01_B_AtkM"": 1,
//                    ""Skill_C_003_01_B_LinkSkill"": 1,
//                    ""Skill_C_003_01_B_Passive"": 1
//                },
//                ""friendship_level"": 1,
//                ""create_at"": 1741236940
//            },
//            ""Char_034_S01_B"": {
//                ""id"": ""Char_034_S01_B"",
//                ""food"": {
//                    ""satiety_update_time"": 1741288386
//                },
//                ""level"": 1,
//                ""grade"": 2,
//                ""skills"": {
//                    ""Skill_C_034_01_B_ActiveSkill"": 1,
//                    ""Skill_C_034_01_B_AtkE"": 1,
//                    ""Skill_C_034_01_B_AtkM"": 1,
//                    ""Skill_C_034_01_B_LinkSkill"": 1,
//                    ""Skill_C_034_01_B_Passive"": 1
//                },
//                ""friendship_level"": 1,
//                ""create_at"": 1741288386
//            },
//            ""Char_064_S01_R"": {
//                ""id"": ""Char_064_S01_R"",
//                ""food"": {
//                    ""satiety_update_time"": 1741288386
//                },
//                ""level"": 1,
//                ""grade"": 2,
//                ""skills"": {
//                    ""Skill_C_064_01_R_ActiveSkill"": 1,
//                    ""Skill_C_064_01_R_AtkE"": 1,
//                    ""Skill_C_064_01_R_AtkM"": 1,
//                    ""Skill_C_064_01_R_LinkSkill"": 1,
//                    ""Skill_C_064_01_R_Passive"": 1
//                },
//                ""friendship_level"": 1,
//                ""create_at"": 1741288386
//            },
//            ""Char_080_S01_G"": {
//                ""id"": ""Char_080_S01_G"",
//                ""food"": {
//                    ""satiety_update_time"": 1741288386
//                },
//                ""level"": 1,
//                ""grade"": 1,
//                ""skills"": {
//                    ""Skill_C_080_01_G_ActiveSkill"": 1,
//                    ""Skill_C_080_01_G_AtkE"": 1,
//                    ""Skill_C_080_01_G_AtkM"": 1,
//                    ""Skill_C_080_01_G_LinkSkill"": 1,
//                    ""Skill_C_080_01_G_Passive"": 1
//                },
//                ""friendship_level"": 1,
//                ""create_at"": 1741288386
//            },
//            ""Char_089_S01_D"": {
//                ""id"": ""Char_089_S01_D"",
//                ""food"": {
//                    ""satiety_update_time"": 1741288386
//                },
//                ""level"": 1,
//                ""grade"": 2,
//                ""skills"": {
//                    ""Skill_C_089_01_D_ActiveSkill"": 1,
//                    ""Skill_C_089_01_D_AtkE"": 1,
//                    ""Skill_C_089_01_D_AtkM"": 1,
//                    ""Skill_C_089_01_D_LinkSkill"": 1,
//                    ""Skill_C_089_01_D_Passive"": 1
//                },
//                ""friendship_level"": 1,
//                ""create_at"": 1741288386
//            },
//            ""Char_100_S01_G"": {
//                ""id"": ""Char_100_S01_G"",
//                ""food"": {
//                    ""satiety_update_time"": 1741288386
//                },
//                ""level"": 1,
//                ""grade"": 2,
//                ""skills"": {
//                    ""Skill_C_100_01_G_ActiveSkill"": 1,
//                    ""Skill_C_100_01_G_AtkE"": 1,
//                    ""Skill_C_100_01_G_AtkM"": 1,
//                    ""Skill_C_100_01_G_LinkSkill"": 1,
//                    ""Skill_C_100_01_G_Passive"": 1
//                },
//                ""friendship_level"": 1,
//                ""create_at"": 1741288386
//            },
//            ""Char_101_S01_B"": {
//                ""id"": ""Char_101_S01_B"",
//                ""food"": {
//                    ""satiety_update_time"": 1741288386
//                },
//                ""level"": 1,
//                ""grade"": 3,
//                ""skills"": {
//                    ""Skill_C_101_01_B_ActiveSkill"": 1,
//                    ""Skill_C_101_01_B_AtkE"": 1,
//                    ""Skill_C_101_01_B_AtkM"": 1,
//                    ""Skill_C_101_01_B_LinkSkill"": 1,
//                    ""Skill_C_101_01_B_Passive"": 1
//                },
//                ""friendship_level"": 1,
//                ""create_at"": 1741288386
//            },
//            ""Char_103_S01_G"": {
//                ""id"": ""Char_103_S01_G"",
//                ""food"": {
//                    ""satiety_update_time"": 1741236940
//                },
//                ""level"": 1,
//                ""grade"": 2,
//                ""skills"": {
//                    ""Skill_C_103_01_G_ActiveSkill"": 1,
//                    ""Skill_C_103_01_G_AtkE"": 1,
//                    ""Skill_C_103_01_G_AtkM"": 1,
//                    ""Skill_C_103_01_G_LinkSkill"": 1,
//                    ""Skill_C_103_01_G_Passive"": 1
//                },
//                ""friendship_level"": 1,
//                ""create_at"": 1741236940
//            }
//        },
//        ""items"": {
//            ""Item_Coin_MemoryCoin"": {
//                ""id"": ""Item_Coin_MemoryCoin"",
//                ""count"": 16
//            },
//            ""Item_Material_HeroGradeUp_Char_001_S01_B"": {
//                ""id"": ""Item_Material_HeroGradeUp_Char_001_S01_B"",
//                ""count"": 1
//            },
//            ""Item_Material_HeroGradeUp_Char_002_S01_R"": {
//                ""id"": ""Item_Material_HeroGradeUp_Char_002_S01_R"",
//                ""count"": 10
//            },
//            ""Item_Material_HeroGradeUp_Char_034_S01_B"": {
//                ""id"": ""Item_Material_HeroGradeUp_Char_034_S01_B"",
//                ""count"": 5
//            },
//            ""Item_Ticket_DestroyTicket"": {
//                ""id"": ""Item_Ticket_DestroyTicket"",
//                ""count"": 20
//            },
//            ""Item_Ticket_GachaTicket"": {
//                ""id"": ""Item_Ticket_GachaTicket"",
//                ""count"": 5
//            }
//        },
//        ""points"": {
//            ""Point_AP"": {
//                ""id"": ""Point_AP"",
//                ""count"": 220,
//                ""action_time"": 1741306758
//            },
//            ""Point_DungeonTicket"": {
//                ""id"": ""Point_DungeonTicket"",
//                ""count"": 8
//            },
//            ""Point_FreeDia"": {
//                ""id"": ""Point_FreeDia"",
//                ""count"": 150
//            },
//            ""Point_Gold"": {
//                ""id"": ""Point_Gold"",
//                ""count"": 10000
//            },
//            ""Point_TotalWar_Ticket"": {
//                ""id"": ""Point_TotalWar_Ticket"",
//                ""count"": 3
//            }
//        },
//        ""arenas"": {
//            ""Arena_Basic"": {
//                ""id"": ""Arena_Basic"",
//                ""season"": 1,
//                ""update_at"": 1741236940,
//                ""create_at"": 1741236940
//            }
//        },
//        ""summons"": {
//            ""Summon_Tutorial_1"": {
//                ""id"": ""Summon_Tutorial_1"",
//                ""content"": 1
//            }
//        },
//        ""episode_groups"": {
//            ""Story_Sub_Prologue"": {
//                ""story_id"": ""Story_Sub_Prologue"",
//                ""complete_episode_id"": ""Episode_S_Prologue_05"",
//                ""is_group_complete"": true
//            }
//        },
//        ""kingdom_objects"": {
//            ""AdventureShortCut"": {
//                ""id"": ""AdventureShortCut"",
//                ""rank"": 1,
//                ""create_time"": 1741236940
//            },
//            ""Castle"": {
//                ""id"": ""Castle"",
//                ""rank"": 1,
//                ""create_time"": 1741236940
//            }
//        },
//        ""tutorials"": {
//            ""Tutorial_Adventure1"": {
//                ""id"": ""Tutorial_Adventure1""
//            },
//            ""Tutorial_Adventure2"": {
//                ""id"": ""Tutorial_Adventure2""
//            },
//            ""Tutorial_BattleSkill1"": {
//                ""id"": ""Tutorial_BattleSkill1""
//            },
//            ""Tutorial_BattleSkill2"": {
//                ""id"": ""Tutorial_BattleSkill2""
//            },
//            ""Tutorial_DorothyActiveEffect1"": {
//                ""id"": ""Tutorial_DorothyActiveEffect1""
//            },
//            ""Tutorial_Prologue1"": {
//                ""id"": ""Tutorial_Prologue1""
//            },
//            ""Tutorial_PrologueBatttle1"": {
//                ""id"": ""Tutorial_PrologueBatttle1""
//            },
//            ""Tutorial_Summon1"": {
//                ""id"": ""Tutorial_Summon1""
//            },
//            ""Tutorial_Summon2"": {
//                ""id"": ""Tutorial_Summon2""
//            }
//        },
//        ""alarms"": {
//            ""3"": {
//                ""content_type"": 3,
//                ""contents"": [
//                    ""Mail""
//                ]
//            },
//            ""5"": {
//                ""content_type"": 5,
//                ""contents"": [
//                    ""2"",
//                    ""4"",
//                    ""6""
//                ]
//            }
//        },
//        ""parties"": {
//            ""4"": {
//                ""battle_mode_party_type"": 4,
//                ""chars"": [
//                    ""Char_002_S01_R"",
//                    ""Char_101_S01_B"",
//                    ""Char_103_S01_G"",
//                    ""Char_001_S01_B"",
//                    ""Char_003_S01_B""
//                ]
//            }
//        }
//    }
//}
//", "application/json");
//        }

        //member/api/v1/game/auth/login/verify/token/refresh
        [Route("aaaaoz/auth/access")]
        public IResult sPostAuthAccess()
        {
            Log.Information("GetCheckAvailable");

            return Results.Text(@"
{
    ""error"": {
        ""message"": ""success""
    },
    ""login_info"": {
        ""im_id"": ""WFE9ABV4DY53R9F6Q9A7"",
        ""session_key"": ""9d6176e7-83a4-481f-942a-f1fb42c7e73f"",
        ""session_expire_time"": 1741238095,
        ""server_time"": 1741236295,
        ""server_daily_reset_time"": 1741287600,
        ""lobby"": {
            ""place_char_ids"": [
                ""Char_001_S01_B""
            ]
        },
        ""reader"": {
            ""level"": 1,
            ""login_time"": 1741236295,
            ""create_time"": 1741235105,
            ""profiles"": {
                ""1"": {
                    ""type"": 1,
                    ""value"": ""WFE9ABV4DY53R9F6Q9A7""
                },
                ""2"": {
                    ""type"": 2,
                    ""value"": ""03-05-23-25-01""
                },
                ""3"": {
                    ""type"": 3,
                    ""value"": ""4"",
                    ""update_at"": 1741235105
                },
                ""4"": {
                    ""type"": 4,
                    ""value"": ""Title_Default""
                },
                ""7"": {
                    ""type"": 7,
                    ""value"": ""Char_001_S01_B""
                },
                ""8"": {
                    ""type"": 8,
                    ""value"": ""3d389fdc-6f9f-423f-967e-4ebd67147880""
                }
            }
        },
        ""kingdom"": {
            ""schedule_ticket_cnt"": 2,
            ""schedule_ticket_reset_time"": 1741258800,
            ""system_invite_reset_time"": 1741258800,
            ""invite_chars"": {
                ""Char_001_S01_B"": {
                    ""id"": ""Char_001_S01_B"",
                    ""enable_interaction"": true
                },
                ""Char_010_S01_B"": {
                    ""id"": ""Char_010_S01_B"",
                    ""enable_interaction"": true
                },
                ""Char_078_S01_R"": {
                    ""id"": ""Char_078_S01_R"",
                    ""enable_interaction"": true
                },
                ""Char_084_S01_G"": {
                    ""id"": ""Char_084_S01_G"",
                    ""enable_interaction"": true
                },
                ""Char_088_S01_R"": {
                    ""id"": ""Char_088_S01_R"",
                    ""enable_interaction"": true
                },
                ""Char_105_S01_B"": {
                    ""id"": ""Char_105_S01_B"",
                    ""enable_interaction"": true
                }
            }
        },
        ""identifier"": {
            ""create_time"": 1741235105
        },
        ""chars"": {
            ""Char_001_S01_B"": {
                ""id"": ""Char_001_S01_B"",
                ""food"": {
                    ""satiety_update_time"": 1741235105
                },
                ""level"": 1,
                ""grade"": 1,
                ""skills"": {
                    ""Skill_C_001_01_B_ActiveSkill"": 1,
                    ""Skill_C_001_01_B_AtkE"": 1,
                    ""Skill_C_001_01_B_AtkM"": 1,
                    ""Skill_C_001_01_B_LinkSkill"": 1,
                    ""Skill_C_001_01_B_Passive"": 1
                },
                ""friendship_level"": 1,
                ""create_at"": 1741235105
            },
            ""Char_002_S01_R"": {
                ""id"": ""Char_002_S01_R"",
                ""food"": {
                    ""satiety_update_time"": 1741235105
                },
                ""level"": 1,
                ""grade"": 2,
                ""skills"": {
                    ""Skill_C_002_01_R_ActiveSkill"": 1,
                    ""Skill_C_002_01_R_AtkE"": 1,
                    ""Skill_C_002_01_R_AtkM"": 1,
                    ""Skill_C_002_01_R_LinkSkill"": 1,
                    ""Skill_C_002_01_R_Passive"": 1
                },
                ""friendship_level"": 1,
                ""create_at"": 1741235105
            },
            ""Char_003_S01_B"": {
                ""id"": ""Char_003_S01_B"",
                ""food"": {
                    ""satiety_update_time"": 1741235105
                },
                ""level"": 1,
                ""grade"": 2,
                ""skills"": {
                    ""Skill_C_003_01_B_ActiveSkill"": 1,
                    ""Skill_C_003_01_B_AtkE"": 1,
                    ""Skill_C_003_01_B_AtkM"": 1,
                    ""Skill_C_003_01_B_LinkSkill"": 1,
                    ""Skill_C_003_01_B_Passive"": 1
                },
                ""friendship_level"": 1,
                ""create_at"": 1741235105
            },
            ""Char_103_S01_G"": {
                ""id"": ""Char_103_S01_G"",
                ""food"": {
                    ""satiety_update_time"": 1741235105
                },
                ""level"": 1,
                ""grade"": 2,
                ""skills"": {
                    ""Skill_C_103_01_G_ActiveSkill"": 1,
                    ""Skill_C_103_01_G_AtkE"": 1,
                    ""Skill_C_103_01_G_AtkM"": 1,
                    ""Skill_C_103_01_G_LinkSkill"": 1,
                    ""Skill_C_103_01_G_Passive"": 1
                },
                ""friendship_level"": 1,
                ""create_at"": 1741235105
            }
        },
        ""points"": {
            ""Point_AP"": {
                ""id"": ""Point_AP"",
                ""count"": 120,
                ""action_time"": 1741235105
            },
            ""Point_DungeonTicket"": {
                ""id"": ""Point_DungeonTicket"",
                ""count"": 8
            },
            ""Point_FreeDia"": {
                ""id"": ""Point_FreeDia"",
                ""count"": 150
            },
            ""Point_Gold"": {
                ""id"": ""Point_Gold"",
                ""count"": 10000
            },
            ""Point_TotalWar_Ticket"": {
                ""id"": ""Point_TotalWar_Ticket"",
                ""count"": 3
            }
        },
        ""arenas"": {
            ""Arena_Basic"": {
                ""id"": ""Arena_Basic"",
                ""season"": 1,
                ""update_at"": 1741235105,
                ""create_at"": 1741235105
            }
        },
        ""kingdom_objects"": {
            ""AdventureShortCut"": {
                ""id"": ""AdventureShortCut"",
                ""rank"": 1,
                ""create_time"": 1741235105
            },
            ""Castle"": {
                ""id"": ""Castle"",
                ""rank"": 1,
                ""create_time"": 1741235105
            }
        },
        ""alarms"": {
            ""5"": {
                ""content_type"": 5,
                ""contents"": [
                    ""2""
                ]
            }
        },
        ""parties"": {
            ""4"": {
                ""battle_mode_party_type"": 4,
                ""chars"": [
                    ""Char_001_S01_B"",
                    ""Char_103_S01_G"",
                    ""Char_003_S01_B"",
                    ""Char_002_S01_R""
                ]
            }
        }
    }
}
", "application/json");
        }

//        {
//    ""error"": {
//        ""code"": 1000,
//        ""message"": ""invalid access""
//    }
//}

        [Route("member/api/v1/game/auth/signin")]
        public IResult PostAuthSignIn()
        {
            Log.Information("PostAuthSignIn");

            return Results.Text(@"
{
    ""resultCode"": ""SUCCESS"",
    ""resultData"": {
        ""adNightPush"": true,
        ""adPush"": true,
        ""advertising"": true,
        ""imId"": ""PFFXZ28WG7LP9DEKT7Q4"",
        ""loginVerifyToken"": ""eyJhbGciOiJIUzI1NiJ9.eyJpbUlkIjoiUEZGWFoyOFdHN0xQOURFS1Q3UTQiLCJwaklkIjoiMTAwOCIsInR5cGUiOiJMT0dJTl9WRVJJRlkiLCJzdWIiOiJkYTY0YjhhMi1jNmYzLTQzYzAtYTVjMy02MGFjZTM5MmM4ZGUiLCJpc3MiOiJoeWJlaW0tcGxhdGZvcm0tcCIsImF1ZCI6WyJoeWJlaW0tc2VydmVyLXAiXSwiaWF0IjoxNzQxMjU5MzE4LCJleHAiOjE3NDEyNjI5MTh9.rZrDRK05mRE0vdUGVAyJD3GfubUQCHfkjWxsgbxlzlc""
    },
    ""resultMessage"": ""success""
}
");
        }

        [HttpGet("{*catchAll}")]
        public IResult CatchAllGet(string catchAll)
        {
            Log.Information($"HttpGet: {catchAll}");
            return Results.Empty;
        }

        [HttpPost("{*catchAll}")]
        public IResult CatchAllPost(string catchAll)
        {
            Log.Information($"HttpGet: {catchAll}");
            return Results.Empty;
        }
    }
}

