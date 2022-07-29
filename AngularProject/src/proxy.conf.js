const PROXY_CONFIG = [
  {
    context: [
      "/company",
    ],
    target: "https://localhost:44352",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
