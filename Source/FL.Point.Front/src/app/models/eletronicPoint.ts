import { EletronicPointType } from "./eletronicPointType"

export interface EletronicPoint {
    id       : number
    markData : Date
    type     : EletronicPointType
    user     : bigint
    comment  : string
    createdAt: Date
    deletedAt: Date
}