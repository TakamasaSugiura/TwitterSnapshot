namespace TwitterSnapshot

open CoreTweet
open CoreTweet.Core

type UserModel(user, screenName, id) =
    
    //#region backing store
    let mutable m_user:UserResponse = user
    let mutable m_screenName = screenName
    let mutable m_id = id
    //#endregion

    //#region properties
    member this.User
        with get() = m_user
        and set(value) = m_user <- value

    member this.ScreenName
        with get() = m_screenName
        and set(value) = m_screenName <- value

    member this.Id
        with get() = m_id
        and set(value) = m_id <- value
    //#endregion

    new(user) =
        UserModel(user, "", 0)
    new(screenName) =
        UserModel(null, screenName, 0)
    new(id) =
        UserModel(null, "", id)
    

