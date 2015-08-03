namespace TwitterSnapshot

type RecordModel() =
    let mutable m_userList = new ResizeArray<UserModel>()

    member this.UserList
        with get() = m_userList
        and set(value) = m_userList <- value

