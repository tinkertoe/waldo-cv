export interface WaldoImageData {
  data: Uint8ClampedArray | Float32Array,
  width: number,
  height: number
}

export interface WaldoTexture {
  texture: WebGLTexture,
  dimensions: Dimensions
}

export interface Point {
  x: number,
  y: number
}

export interface Dimensions {
  w: number,
  h: number
}

export interface Region {
  origin: Point,
  dimensions: Dimensions
}

export interface Chunk {
  region: Region,
  computeSimilaritiesResult?: WaldoTexture,
  averageSimilaritiesResult?: WaldoTexture,
  findHighestSimilaritiesResult?: WaldoTexture,
  findHighestSimilarityResult?: WaldoTexture,
}

export interface Match {
  location: Point
  similarity: number,
  timestamp?: number
}