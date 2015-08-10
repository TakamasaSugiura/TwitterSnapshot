namespace TwitterSnapshot

open CoreTweet
open System
open System.Collections.Generic

type Camera(consumerKey, consumerSecret, accessToken, accessSecret) = 
    let m_token = Tokens.Create(consumerKey, consumerSecret, accessToken, accessSecret)
    let m_records = new RecordModel()
    member this.TakeUser(screenName:string) =
        let param = new Dictionary<string, Object>()
        param.["screen_name"] <- screenName
        m_records.AddUser(m_token.Users.Show(param))
