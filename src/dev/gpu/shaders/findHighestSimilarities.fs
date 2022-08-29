precision lowp float;

uniform sampler2D u_averageSimilarities;
uniform vec2 u_averageSimilaritiesDimensions;

void main() {
  float highestSimilarityValue = 0.0;
  int highestSimilarityXCoord = 0;

  for(int x = 0; x < int(u_averageSimilaritiesDimensions.x); x++) {
    vec2 texCoord = vec2(x, gl_FragCoord.y);
    vec4 texel = texture2D(u_averageSimilarities, (texCoord - vec2(0.25)) / u_averageSimilaritiesDimensions);
    if (texel.r > highestSimilarityValue) {
      highestSimilarityValue = texel.r;
      highestSimilarityXCoord = int(max(0.0, float(x-1)));
    }
  }

  gl_FragColor = vec4(highestSimilarityValue, highestSimilarityXCoord, 0, 0);
}