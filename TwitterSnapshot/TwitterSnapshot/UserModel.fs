namespace TwitterSnapshot

open CoreTweet
open CoreTweet.Core

type UserModel() =
    let mutable m_user = new UserResponse()
    member this.User
        with get() = m_user
        and set(value) = m_user <- value

    

