﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord;

namespace Piece_Of_Shit.Commands
{
    public class Meme : ModuleBase<SocketCommandContext>
    {
        Random rand;

        string[] memes = new string[]
       {
            "https://imgur.com/JYcNmuO","https://imgur.com/U0dn8vj","https://imgur.com/22Hs7L5","https://imgur.com/22Hs7L5","https://imgur.com/GoROABi","https://imgur.com/UBUdIuO","https://imgur.com/o22yWNw",
            "https://imgur.com/UXUppvU","https://imgur.com/XJZQekh","https://imgur.com/lc3MJuz","https://imgur.com/uRSO9JR","https://imgur.com/oxia4iZ","https://imgur.com/pS6GtSr","https://imgur.com/tbqlq3b",
            "https://imgur.com/DdRcLBP","https://imgur.com/opICBR6","https://imgur.com/awhGGV6","https://imgur.com/GxlUutm","https://imgur.com/LeiSs7Z","https://imgur.com/erMWDuX","https://imgur.com/KTOm9FU",
            "https://imgur.com/PoCjhsM","https://imgur.com/F72QsgG","https://imgur.com/oxtzQSH","https://imgur.com/CfYcvrg","https://imgur.com/51DaG6B","https://imgur.com/K5DidsK","https://imgur.com/MSFaasE",
            "https://imgur.com/bkhSyYC","https://imgur.com/TcGxGzU","https://imgur.com/P2rsQ60","https://imgur.com/Iz8JRc2","https://imgur.com/emjDnrG","https://imgur.com/PEBq6Te","https://imgur.com/JogfCXq",
            "https://imgur.com/pKdB9gW","https://imgur.com/w6PTZeC","https://imgur.com/lGfhKyG","https://imgur.com/Kd3dXWo","https://imgur.com/c3F8bF8","https://imgur.com/Kfnuhou","https://imgur.com/emH85Na",
            "https://imgur.com/qOx5fwS","https://imgur.com/Qfruxad","https://imgur.com/JlBRdlA","https://imgur.com/P4pdTPI","https://imgur.com/pWAI5mX","https://imgur.com/mulhgaU","https://imgur.com/9xEbVPp",
            "https://imgur.com/QUCiJqN","https://imgur.com/lLJy4xG","https://imgur.com/tLvmR7A","https://imgur.com/VtZgPYg","https://imgur.com/9MQL7Xd","https://imgur.com/c5UmUmW","https://imgur.com/D4N8AOT",
            "https://imgur.com/q5QL4OR","https://imgur.com/So8bnqY","https://imgur.com/GOSP9pR","https://imgur.com/XstIQ7K","https://imgur.com/suxeUIA","https://imgur.com/0j48pYV","https://imgur.com/rb06eF5",
            "https://imgur.com/IGuNPZi","https://imgur.com/Z5cr1qO","https://imgur.com/AixxZ5B","https://imgur.com/tE9767V","https://imgur.com/CaGOYGY","https://imgur.com/OfU3dsG","https://imgur.com/Ax1lb4H",
            "https://imgur.com/XY4JnPW","https://imgur.com/rJu5zff","https://imgur.com/Lss7LvL","https://imgur.com/oyKLx8p","https://imgur.com/zG2m5WH","https://imgur.com/3crEMpk","https://imgur.com/ZAGEqy7",
            "https://imgur.com/xy8R4Jv","https://imgur.com/8l1EDqc","https://imgur.com/oPoRy5A","https://imgur.com/FkSHFTh","https://imgur.com/FKc4Mf8","https://imgur.com/cxPjfmf","https://imgur.com/1JndX5i",
            "https://imgur.com/WCyUWHl","https://imgur.com/b2o9mt2","https://imgur.com/49SGthN","https://imgur.com/GdA602k","https://imgur.com/HJ1RVyE","https://imgur.com/dmtrEhk","https://imgur.com/2i7jhrd",
            "https://imgur.com/vaeuKwk","https://imgur.com/upDzsRd","https://imgur.com/d58VLRY","https://imgur.com/ZTpwngU","https://imgur.com/xzKqIMv","https://imgur.com/sJRn7XG","https://imgur.com/AB5HNiT",
            "https://imgur.com/HsapJqQ","https://imgur.com/SXGP1aM","https://imgur.com/3Atbaag","https://imgur.com/rlBeGZS","https://imgur.com/hARspOf","https://imgur.com/0qkBFyt","https://imgur.com/e9AXoVk",
            "https://imgur.com/B6wHGqA","https://imgur.com/7rzYrgv","https://imgur.com/vxgTsZd","https://imgur.com/mmoSoMQ","https://imgur.com/fQj4HJA","https://imgur.com/bKcphR2","https://imgur.com/UmukPo9",
            "https://imgur.com/YSCGAz3","https://imgur.com/L2YaOei","https://imgur.com/EuIdIG1","https://imgur.com/MRNJ7Ol","https://imgur.com/zcKogkG","https://imgur.com/88qdwNm","https://imgur.com/dMJHsSr",
            "https://imgur.com/nIgx5yD","https://imgur.com/hNVPKCN","https://imgur.com/UTyb8Ff","https://imgur.com/xGOEjJE","https://imgur.com/u0eRM4N","https://imgur.com/IiCWO68","https://imgur.com/XfFBmAb",
            "https://imgur.com/aCgesx6","https://imgur.com/bKtRbpA","https://imgur.com/76KAbTB","https://imgur.com/kIYQBhI","https://imgur.com/LgkDJpO","https://imgur.com/LNNnwdN","https://imgur.com/jrtSuJd",
            "https://imgur.com/27N9emB","https://imgur.com/e7EKeOI","https://imgur.com/3eAitmV","https://imgur.com/mdTs1QR","https://imgur.com/RQz1LPo","https://imgur.com/09fVppq","https://imgur.com/OhatLkW",
            "https://imgur.com/TMe2A5M","https://imgur.com/A17w0gj","https://imgur.com/1sg5KUH","https://imgur.com/uxxSbDg","https://imgur.com/dnXC3jM","https://imgur.com/Wq2QS1O","https://imgur.com/RJCSjpV",
            "https://imgur.com/aYWCLMV","https://imgur.com/TV8ZbM2","https://imgur.com/wp3CkPb","https://imgur.com/8y8AGuz","https://imgur.com/ig322GQ","https://imgur.com/RUq2b9B","https://imgur.com/SJaDVBM",
            "https://imgur.com/zWaYHvi","https://imgur.com/9LEGC1D","https://imgur.com/v4XqHnY","https://imgur.com/xDTMboL","https://imgur.com/NkH5lI5","https://imgur.com/YPwM6Os","https://imgur.com/SCzUHvF",
            "https://imgur.com/umj5bqO","https://imgur.com/icpoMHu","https://imgur.com/J5phTzN","https://imgur.com/hn6vvBp","https://imgur.com/CDLCHfA","https://imgur.com/PuIaCd2","https://imgur.com/VdgFbOG",
            "https://imgur.com/zBV7vMh","https://imgur.com/FNmRdbo","https://imgur.com/6idun51","https://imgur.com/RtYhRfJ","https://imgur.com/vU4VLay","https://imgur.com/E39vrTK","https://imgur.com/aatfcGP",
            "https://imgur.com/0fcvdMt","https://imgur.com/D8h0eaD","https://imgur.com/96MJDYi","https://imgur.com/TrHoPmc","https://imgur.com/0srv4t0","https://imgur.com/hnmQm0c","https://imgur.com/aoQdFlc",
            "https://imgur.com/sNwgaVj","https://imgur.com/gFhUT6h","https://imgur.com/yxXgIen","https://imgur.com/ZQwMKVR","https://imgur.com/8IMOuxE","https://imgur.com/LzgxDpV","https://imgur.com/it4XWrS",
            "https://imgur.com/JZWR3RQ","https://imgur.com/iFBvxpA","https://imgur.com/EWIYAkf","https://imgur.com/ntr3qk6","https://imgur.com/HDxrp5Z","https://imgur.com/ZT7giFO","https://imgur.com/sXWPIFc",
            "https://imgur.com/9xCVjpR","https://imgur.com/JcX0BBR","https://imgur.com/z29XkBO","https://imgur.com/zGcqvrq","https://imgur.com/b5gEBMB","https://imgur.com/XxH0h55","https://imgur.com/dPnqAZU",
            "https://imgur.com/zZXt6cA","https://imgur.com/kMnsJFp","https://imgur.com/whbX0tz","https://imgur.com/2qx7RaA","https://imgur.com/HwP3JiA","https://imgur.com/47pCvaR","https://imgur.com/w7mslrc",
            "https://imgur.com/dvjLbLk","https://imgur.com/O232JMR","https://imgur.com/rdnAk9f","https://imgur.com/dpsfuZq","https://imgur.com/lWLBvzZ","https://imgur.com/wYpsgV1","https://imgur.com/a/JfN7t",
            "https://imgur.com/RmSXtn8","https://imgur.com/a/YBcDG","https://imgur.com/a/EY5QI","https://imgur.com/a/4DtTq","https://imgur.com/a/wkWQ3","https://imgur.com/a/Y1288","https://imgur.com/XTayCTp",
            "https://imgur.com/vQWElGh","https://imgur.com/RxXDKoM","https://imgur.com/en8OiuV","https://imgur.com/fTyL7VJ","https://imgur.com/taQilEZ","https://imgur.com/hndWukm","https://imgur.com/6Xmaolh",
            "https://imgur.com/mELqlMH","https://imgur.com/IA2veBP","https://imgur.com/WdSIKwk","https://imgur.com/MGT003R","https://imgur.com/jReHHXN","https://imgur.com/k1jaisY","https://imgur.com/oV3pzHt",
            "https://imgur.com/1537wue","https://imgur.com/ZivW9JR","https://imgur.com/dKUXxlw","https://imgur.com/7iw5o4L","https://imgur.com/D0VkJYH","https://imgur.com/ljeaC5x","https://imgur.com/73yGRDU",
            "https://imgur.com/NJfN8d4","https://imgur.com/B8ck86c","https://imgur.com/zdXuKTr","https://imgur.com/Q7BH6Rg","https://imgur.com/EEop0Ob","https://imgur.com/y8KUwGl","https://imgur.com/SkSd3jK",
            "https://imgur.com/1G2GQco","https://imgur.com/wPnwzrF","https://imgur.com/Vs3bzOQ","https://imgur.com/rdWEADo","https://imgur.com/SME1UAe","https://imgur.com/UQ9cE6F","https://imgur.com/PqFTGrA",
            "https://imgur.com/0dNGd4j","https://imgur.com/p73pENk","https://imgur.com/dFl6jxb","https://imgur.com/tDCNZqV","https://imgur.com/3v60B6V","https://imgur.com/6wEFcIQ","https://imgur.com/tdnDjVQ",
            "https://imgur.com/UpLr4Jl","https://imgur.com/1ICyUVk","https://imgur.com/jOqxvI7","https://imgur.com/qZ4lT4y","https://imgur.com/brUdkqx","https://imgur.com/SWdFMch","https://imgur.com/6HdpWTU",
            "https://imgur.com/QzN8UNM","https://imgur.com/cDrkmVw","https://imgur.com/eiioD2R","https://imgur.com/dWDci52","https://imgur.com/MZnv6Zk","https://imgur.com/Fx6jsdS","https://imgur.com/kXY86kt",
            "https://imgur.com/oswGpod","https://imgur.com/zHgpYW9","https://imgur.com/JoSesCJ","https://imgur.com/ghU0852","https://imgur.com/hylw22a","https://imgur.com/0Gqq1eE","https://imgur.com/2YKQHLx",
            "https://imgur.com/xGq7qtf","https://imgur.com/rwzGO8d","https://imgur.com/lKeUT2Y","https://imgur.com/fU3qrbO","https://imgur.com/EU9MQdO","https://imgur.com/Ayfa2Ya","https://imgur.com/SYC3vQP",
            "https://imgur.com/3IRbjkw","https://imgur.com/tYB8zGg","https://imgur.com/o6NWIzP","https://imgur.com/1Ds2qwZ","https://imgur.com/mfLXBMp","https://imgur.com/iWlek1R","https://imgur.com/ZmpI1og",
            "https://imgur.com/oWHcdef","https://imgur.com/A1hnRiM",
       };
        
        [Command("meme")]
        public async Task meme()
        {
            rand = new Random();
            int randomIndex = rand.Next(memes.Length);
            string text = memes[randomIndex];

            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss: ") + ($"{Context.User.Username} Used Meme Command"));
            Console.WriteLine(text);

            await ReplyAsync(text);
        }
    }
}
