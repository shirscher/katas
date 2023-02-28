import { disappearingPairs } from "./index";

describe("disappearingPairs", () => {
    it("should return the string with all pairs of adjacent letters removed", () => {
        expect(disappearingPairs("abccba")).toBe("");
        expect(disappearingPairs("foobar")).toBe("fbar");
        expect(disappearingPairs("abccbefggfe")).toBe("a");
    });
});