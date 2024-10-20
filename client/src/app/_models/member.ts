import { Photo } from "./photo"

export interface Member {
  idUser: number
  username: string
  age: number
  photoUrl: string
  knownAs: string
  createdAt: Date
  lastActive: Date
  gender: string
  introduction: string
  lookingFor: string
  city: string
  country: string
  photos: Photo[]
}

