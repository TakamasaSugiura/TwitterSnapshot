namespace TwitterSnapshot

open System
open System.Collections.Generic
open CoreTweet.CoreTweetFSharp
open CoreTweet

type Camera(consumerKey, consumerSecret, accessToken, accessSecret) = 
    let m_token = Tokens.Create(consumerKey, consumerSecret, accessToken, accessSecret)

    member this.TakeUser(screenName) =
        let param = new Dictionary<string, Object>()
        param.["screen_name"] <- screenName
        m_token.Users.Show(param)
