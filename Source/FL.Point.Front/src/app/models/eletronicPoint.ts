import { eletronicPointType } from "./eletronicPointType"

export class eletronicPoint {
    id       : number
    markData : Date
    type     : eletronicPointType
    user     : bigint
    comment  : string
    createdAt: Date
    deletedAt: Date
}