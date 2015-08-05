namespace TwitterSnapshot

open CoreTweet
open CoreTweet.Core

type RecordModel() =
    let mutable m_userList = new ResizeArray<UserModel>()

    member this.UserList
        with get() = m_userList
        and set(value) = m_userList <- value

    member this.AddUser(user : UserResponse) =
        match user with
        | null -> ()
        | _ -> m_userList.Add(new UserModel(user))